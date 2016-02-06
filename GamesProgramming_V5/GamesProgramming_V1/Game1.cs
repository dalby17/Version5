using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Text;

namespace GamesProgramming_V1
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        SpriteFont timerFont, scoreFont;
        Texture2D background, player, platform, flag, coin;
        Vector2 texturePos;
        Vector2 texturePos1;
        Vector2 texturePos2;
        Vector2 texturePos3;
        Vector2 texturePos4;
        Vector2 texturePos5;
        Vector2 texturePos6;
        Vector2 texturePos7;
        Vector2 texturePos8;
        Vector2 texturePos9;
        Vector2 texturePos10;
        Vector2 texturePos11;

        Vector2 velocity;
        Vector2 acceleration;

        //main menu input
        GameMenu main = new GameMenu();
        //Float for timer starting point
        float timer = 30;
        //Score starting point
        int score = 0;

        //Gravity strength and movement speed
        const float gravity = 500f;
        float moveSpeed = 100f;
        float moveSpeedback = -100f;
        bool hasJumped;

        //collision detection variables
        Point playerFrameSize = new Point(40, 41);
        Point platformFrameSize = new Point(300, 5);
        Point flagFrameSize = new Point(30, 50);
        Point coinFrameSize = new Point(40, 40);
        int playerCollisionRectOffset = 0;
        int platformCollisionRectOffset = 0;
        int flagCollisionRectOffset = 0;
        int coinCollisionRectOffset = 0;

        //Player to object collide function
        protected bool Collide()
        {
            Rectangle playerRect = new Rectangle(
                (int) texturePos.X + playerCollisionRectOffset,
                (int) texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset *2),
                playerFrameSize.Y - (playerCollisionRectOffset *2));
            Rectangle platformRect = new Rectangle(
                (int) texturePos2.X + platformCollisionRectOffset,
                (int) texturePos2.Y + platformCollisionRectOffset,
                platformFrameSize.X - (platformCollisionRectOffset *2),
                platformFrameSize.Y - (platformCollisionRectOffset *2));

            return playerRect.Intersects(platformRect);
        }

        protected bool Collide1()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle platformRect1 = new Rectangle(
               (int)texturePos3.X + platformCollisionRectOffset,
               (int)texturePos3.Y + platformCollisionRectOffset,
               platformFrameSize.X - (platformCollisionRectOffset * 2),
               platformFrameSize.Y - (platformCollisionRectOffset * 2));

            return playerRect.Intersects(platformRect1);
        }

        protected bool Collide2()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle platformRect2 = new Rectangle(
               (int)texturePos6.X + platformCollisionRectOffset,
               (int)texturePos6.Y + platformCollisionRectOffset,
               platformFrameSize.X - (platformCollisionRectOffset * 2),
               platformFrameSize.Y - (platformCollisionRectOffset * 2));

            return playerRect.Intersects(platformRect2);
        }

        protected bool Collide3()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle platformRect3 = new Rectangle(
               (int)texturePos7.X + platformCollisionRectOffset,
               (int)texturePos7.Y + platformCollisionRectOffset,
               platformFrameSize.X - (platformCollisionRectOffset * 2),
               platformFrameSize.Y - (platformCollisionRectOffset * 2));

            return playerRect.Intersects(platformRect3);
        }

        protected bool Collide4()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle platformRect4 = new Rectangle(
               (int)texturePos8.X + platformCollisionRectOffset,
               (int)texturePos8.Y + platformCollisionRectOffset,
               platformFrameSize.X - (platformCollisionRectOffset * 2),
               platformFrameSize.Y - (platformCollisionRectOffset * 2));

            return playerRect.Intersects(platformRect4);
        }

        protected bool Collide5()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle platformRect5 = new Rectangle(
               (int)texturePos10.X + platformCollisionRectOffset,
               (int)texturePos10.Y + platformCollisionRectOffset,
               platformFrameSize.X - (platformCollisionRectOffset * 2),
               platformFrameSize.Y - (platformCollisionRectOffset * 2));

            return playerRect.Intersects(platformRect5);
        }

        protected bool Collide6()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle platformRect6 = new Rectangle(
               (int)texturePos11.X + platformCollisionRectOffset,
               (int)texturePos11.Y + platformCollisionRectOffset,
               platformFrameSize.X - (platformCollisionRectOffset * 2),
               platformFrameSize.Y - (platformCollisionRectOffset * 2));

            return playerRect.Intersects(platformRect6);
        }

        protected bool Collide7()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle platformRect7 = new Rectangle(
               (int)texturePos9.X + platformCollisionRectOffset,
               (int)texturePos9.Y + platformCollisionRectOffset,
               platformFrameSize.X - (platformCollisionRectOffset * 2),
               platformFrameSize.Y - (platformCollisionRectOffset * 2));

            return playerRect.Intersects(platformRect7);
        }
        //velocity hitting from the bottom sets velocity to going down
        protected bool CollideFlag()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle flagRect = new Rectangle(
               (int)texturePos4.X + flagCollisionRectOffset,
               (int)texturePos4.Y + flagCollisionRectOffset,
               flagFrameSize.X - (flagCollisionRectOffset * 2),
               flagFrameSize.Y - (flagCollisionRectOffset * 2));

            return playerRect.Intersects(flagRect);
        }

        protected bool CollideCoin()
        {
            Rectangle playerRect = new Rectangle(
                (int)texturePos.X + playerCollisionRectOffset,
                (int)texturePos.Y + playerCollisionRectOffset,
                playerFrameSize.X - (playerCollisionRectOffset * 2),
                playerFrameSize.Y - (playerCollisionRectOffset * 2));
            Rectangle coinRect = new Rectangle(
               (int)texturePos5.X + coinCollisionRectOffset,
               (int)texturePos5.Y + coinCollisionRectOffset,
               coinFrameSize.X - (coinCollisionRectOffset * 2),
               coinFrameSize.Y - (coinCollisionRectOffset * 2));

            return playerRect.Intersects(coinRect);
        }

        public Game1()
        {
            //Window Size
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 800;
            graphics.PreferredBackBufferHeight = 600;
            Content.RootDirectory = "Content";

            //Texture starting point of background, platforms, flag and coin
            texturePos1 = new Vector2(0, 0);
            texturePos2 = new Vector2(0, 300);
            texturePos3 = new Vector2(300, 400);
            texturePos4 = new Vector2(570, 352);
            texturePos5 = new Vector2(700, 150);
            texturePos6 = new Vector2(50, 100);
            texturePos7 = new Vector2(400, 100);
            texturePos8 = new Vector2(600, 200);
            texturePos9 = new Vector2(200, 200);
            texturePos10 = new Vector2(400, 500);
            texturePos11 = new Vector2(50, 500);

            //Window Title
            this.Activated += (sender, args) => { this.Window.Title = "Super Biker"; };
            this.Deactivated += (sender, args) => { this.Window.Title = "Super Biker (Paused)"; };

            //Pause button
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.P))
            {
                this.Activated += (sender, args) => { this.Window.Title = "Super Biker (Paused)"; };
            }
        }

        protected override void Initialize()
        {
            //Player Spawn
            velocity = new Vector2(0, 0);
            texturePos = new Vector2(0, 250);
            acceleration = new Vector2(0, 0);
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            main.LoadContent(Content);

            //Asset content
            spriteBatch = new SpriteBatch(GraphicsDevice);
            background = this.Content.Load<Texture2D>("Background");
            player = this.Content.Load<Texture2D>("Bike1");
            platform = this.Content.Load<Texture2D>("Platform");
            flag = this.Content.Load<Texture2D>("flag");
            coin = this.Content.Load<Texture2D>("coin");
            timerFont = this.Content.Load<SpriteFont>("Timerfont");
            scoreFont = this.Content.Load<SpriteFont>("Scorefont");
        }

        protected override void UnloadContent()
        {
            Content.Unload();
        }

        protected override void Update(GameTime gameTime)
        {
            //Manin menu update
            main.Update();

            if (IsActive)
            {
                KeyboardState state = Keyboard.GetState();
                //Exit Game through Esc key
                if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                    Exit();

                //Tells what keys are being pressed
                System.Text.StringBuilder sb = new StringBuilder();
                foreach (var key in state.GetPressedKeys())
                    sb.Append("Keys: ").Append(key).Append(" Pressed");

                if(sb.Length > 0)
                System.Diagnostics.Debug.WriteLine(sb.ToString());
                else
                System.Diagnostics.Debug.WriteLine("No Keys Pressed");

               
                //Movement of player character
                if (state.IsKeyDown(Keys.Up))
                    velocity.X = moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                else if (state.IsKeyDown(Keys.Down))
                    velocity.X = moveSpeedback * (float)gameTime.ElapsedGameTime.TotalSeconds;
                else
                    velocity.X = 0;
                
                //velocity.Y = 1f;

                //Jump statements
                if (Keyboard.GetState().IsKeyDown(Keys.Space) && hasJumped == false)
                {
                   acceleration.Y = -0.2f;
                   // texturePos.Y -= 100f;
                    hasJumped = true;
                }

                if (hasJumped == true) //To do only apply in top collide
                {
                    float i = 1;
                    acceleration.Y += 0.01f * i; //acceleration due to gravity
                }

                //collision detection reaction
                if (Collide() || Collide1() || Collide2() || Collide3() || Collide4() || Collide5() || Collide6() || Collide7())
                {
                    hasJumped = false;
                    velocity.Y = 0f;
                    //texturePos += velocity;
                }

                

                velocity += acceleration;
                texturePos += velocity; //update postiion from velocity (should also scale for time)
          
                if (CollideFlag())
                {
                    Exit();
                }

                if (CollideCoin())
                {
                    this.score += 1;
                    texturePos5 = new Vector2(100, 200);
                }

                //collision with window size/cant go off screen
                if (texturePos.X < 0)
                {
                    texturePos.X = 0;
                }
                if (texturePos.Y < 0)
                {
                    texturePos.Y = 0;
                }

                if (texturePos.X > Window.ClientBounds.Width - playerFrameSize.X)
                {
                    texturePos.X = Window.ClientBounds.Width - playerFrameSize.X;
                }
                
                if (texturePos.Y > Window.ClientBounds.Height - playerFrameSize.Y)
                {
                    //Exit();
                }

                //Timer countdown
                timer -= (float)gameTime.ElapsedGameTime.TotalSeconds;
                //When timer hits 0
                if (timer <= 0)
                {
                    Exit();
                }

                //Moving coin when at a certain score
                if (this.score == 2)
                {
                    texturePos5 = new Vector2(50, 50);
                }
                if (this.score == 3)
                {
                    texturePos5 = new Vector2(500, 50);
                }
                if (this.score == 4)
                {
                    texturePos5 = new Vector2(150, 450);
                }
                if (this.score == 5)
                {
                    texturePos5 = new Vector2(1000, 1000);
                }            
                base.Update(gameTime);
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            //Background Color
            GraphicsDevice.Clear(Color.CornflowerBlue);

            //Sprites
            spriteBatch.Begin();
            //main.Draw(spriteBatch);
            spriteBatch.Draw(background, texturePos1);
            spriteBatch.Draw(player, texturePos);
            spriteBatch.Draw(platform, texturePos2);
            spriteBatch.Draw(platform, texturePos3);
            spriteBatch.Draw(platform, texturePos6);
            spriteBatch.Draw(platform, texturePos7);
            spriteBatch.Draw(platform, texturePos8);
            spriteBatch.Draw(platform, texturePos9);
            spriteBatch.Draw(platform, texturePos10);
            spriteBatch.Draw(platform, texturePos11);
            if (this.score >= 5)
            {
                spriteBatch.Draw(flag, texturePos4);
            }
            spriteBatch.Draw(coin, texturePos5);
            spriteBatch.DrawString(timerFont, "Time Left: " + timer.ToString("0"), new Vector2(0, 0), Color.Red);
            spriteBatch.DrawString(scoreFont, "Score: " + score.ToString("0"), new Vector2(725, 0), Color.Red);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
