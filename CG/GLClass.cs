﻿
using CsGL.OpenGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG
{
    public class GLClass : OpenGLControl
    {


        
        private float Hors_bound = 2.85f;
        public int Score_P1 = 0, Score_P2 = 0;
        private const float Pad_bound = 2.09f, Pad_height=1.3f,Pad_width=0.09f,Pad_velo=0.5f;
        private float P1_Pad_y = 0, P2_Pad_y = 0, Pad_x = 4.9f;
        private float ball_velo_x = 0.003f, ball_velo_y = 0.0003f, speed_inc = 0.0005f;
        private float ball_pos_x = 0f, ball_pos_y = 0, ball_rad = 0.15f;
        private bool P1_up_press = false, P1_down_press = false,
                     P2_up_Press = false, P2_down_press = false;
        private bool start,pause = false;
        private double eyeX = 0, eyeY = 0, eyeZ = 7,
                       centerX = 0, centerY = 0, centerZ = 0,
                       upX = 0, upY = 1, upZ = 0;

        Random r1;

        System.Media.SoundPlayer hitPlayer = new System.Media.SoundPlayer(@"Sounds\hit.wav");
        System.Media.SoundPlayer tablePlayer = new System.Media.SoundPlayer(@"Sounds\table.wav");
        System.Media.SoundPlayer scorePoint = new System.Media.SoundPlayer(@"Sounds\point.wav");
        System.Media.SoundPlayer pausePlayer = new System.Media.SoundPlayer(@"Sounds\pause.wav");


        void drawPaddle(float x, float y)
        {
            GL.glPushMatrix();

            GL.glTranslatef(x, y, 0);

            GL.glBegin(GL.GL_QUADS);
            GL.glColor3f(0.0f, 1.0f, 0.0f);
            float height = Pad_height / 2;
            GL.glVertex2f(-Pad_width, height);
            GL.glVertex2f(Pad_width, height);
            GL.glVertex2f(Pad_width, -height);
            GL.glVertex2f(-Pad_width, -height);
            GL.glEnd();

            GL.glPopMatrix();
        }

        void drawBall(float x,float y)
        {
            GL.glPushMatrix();

            GL.glTranslatef(x, y, 0);
            GL.glColor3f(1.0f, 0, 0);
            GL.glutSolidSphere(ball_rad, 20, 16);

            GL.glPopMatrix();
        }
        void drawScores()
        {
           
          
        }



        public GLClass():base()
        {
            this.KeyDown += new KeyEventHandler(onKeyDown);
        }

        protected override void InitGLContext()
        {
            base.InitGLContext();
        }
       

        public override void glDraw()
        {
            GL.glClear(GL.GL_COLOR_BUFFER_BIT);
            GL.glLoadIdentity();

            GL.gluLookAt(eyeX, eyeY, eyeZ, centerX, centerY, centerZ, upX, upY, upZ);

            drawPaddle(-Pad_x, P1_Pad_y);

            drawPaddle(Pad_x, P2_Pad_y);

            drawBall(ball_pos_x,ball_pos_y);
            this.Refresh();
            
        }

        public void play()
        {
            ball_pos_x += ball_velo_x;
            ball_pos_y += ball_velo_y;

            if (ball_pos_y + ball_rad > Hors_bound || ball_pos_y - ball_rad < -Hors_bound)
            {
                ball_velo_y = -ball_velo_y;
                tablePlayer.Play();
            }
            //left Pad P1
            if(/*ball_pos_x - ball_rad - Pad_width < -Pad_x && */ ball_pos_x - ball_rad -0.1  <= -Pad_x)
            {
                if (ball_pos_y < P1_Pad_y + Pad_height && ball_pos_y > P1_Pad_y - Pad_height)
                {
                    ball_velo_x = -ball_velo_x;
                    hitPlayer.Play();
                   // ball_velo_x += speed_inc;
                   // ball_pos_x +=speed_inc;
                }
            }
            //right Pad P2
            if (/*ball_pos_x + ball_rad + Pad_width > Pad_x && */ ball_pos_x + ball_rad + 0.1 >= Pad_x)
            {
                if (ball_pos_y < P2_Pad_y + Pad_height && ball_pos_y > P2_Pad_y - Pad_height)
                {
                    ball_velo_x = -ball_velo_x;
                    hitPlayer.Play();
                    // ball_velo_x -= speed_inc;
                    // ball_pos_x -= 2 * speed_inc;
                }
            }
            //score Left Pad P1
            if (ball_pos_x + ball_rad > Pad_x + Pad_width + 0.53)
            {
                Score_P1++;
                scorePoint.Play();
                Form._Form.update_score_P1(Score_P1);
                ball_pos_x = ball_pos_y = 0;
                r1 = new Random();
                ball_velo_x *= (float)Math.Pow(-1, r1.Next());
                ball_velo_y *= (float)Math.Pow(-1, r1.Next(100));

            }
            
            //score Right Pad P2
            if (ball_pos_x - ball_rad < -Pad_x - Pad_width - 0.53)
            {
                Score_P2++;
                scorePoint.Play();
                Form._Form.update_score_P2(Score_P2);
                ball_pos_x = ball_pos_y = 0;
                r1 = new Random();
                ball_velo_x *= (float)Math.Pow(-1, r1.Next());
                ball_velo_y *= (float)Math.Pow(-1, r1.Next(100));
            }


        }

        public override void Refresh()
        {
            base.Refresh();
            if (start && !pause)
            {
                if (P2_up_Press && P2_Pad_y < Pad_bound)
                {
                    P2_Pad_y += Pad_velo;
                    P2_up_Press = false;

                }
                if (P2_down_press && P2_Pad_y > -Pad_bound)
                {
                    P2_Pad_y -= Pad_velo;
                    P2_down_press = false;

                }

                if (P1_up_press && P1_Pad_y < Pad_bound)
                {
                    P1_Pad_y += Pad_velo;
                    P1_up_press = false;

                }
                if (P1_down_press && P1_Pad_y > -Pad_bound)
                {
                    P1_Pad_y -= Pad_velo;
                    P1_down_press = false;

                }

                play();
            }
           

        }

       

       
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            GL.glMatrixMode(GL.GL_PROJECTION);
            GL.gluPerspective(45.0f, (double)Size.Width / (double)Size.Height, 0.1f, 100.0f);
            GL.glMatrixMode(GL.GL_MODELVIEW);
            GL.glLoadIdentity();
        }

        public void onKeyDown(object Sender, KeyEventArgs key)
        {
            if (key.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
            if(key.KeyCode == Keys.NumPad8)
            {
                P2_up_Press = true;
                
            }
            if (key.KeyCode == Keys.NumPad2)
            {
                P2_down_press = true;
                
            }

            if (key.KeyCode == Keys.W)
            {
                P1_up_press = true;

            }
            if (key.KeyCode == Keys.S)
            {
                P1_down_press = true;

            }
            if (key.KeyCode == Keys.Space)
            {
                if (!start)
                {
                    r1 = new Random();
                    ball_velo_x *= (float)Math.Pow(-1, r1.Next());
                    ball_velo_y *= (float)Math.Pow(-1, r1.Next(100));
                    start = true;
                    Form._Form.startPlayer.Stop();
                }
            }
            if(key.KeyCode == Keys.Enter)
            {
                if (start)
                {
                    pause = !pause;
                    pausePlayer.Play();
                }
            }
        }

    }

}
