using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System;

namespace GroundStation
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Simulation : Microsoft.Xna.Framework.Game
    {
        private IntPtr drawSurface;
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        private Model model;
        public bool customCamEnabled = false;
        public Vector3 cameraPos;
        public float modAngleX = 0, modAngleY = 0, modAngleZ = 0;
        public float angleX = 0;
        public float angleY = 0;
        public float angleZ = 0;
        private Vector3 position = new Vector3(0, 0, 0); // POSITION MATRIX Y AXS MAKED 45 TO SEE IN THE MIDDLE SATELLEITE.
        private Matrix positionMatrix = Matrix.CreateTranslation(new Vector3(0,0,0)); // positionMatrix = CreateTranslation(position)
        private Matrix view = Matrix.CreateLookAt(new Vector3(200, 200, 200), new Vector3(0, 0, 0), Vector3.UnitY);
        private Matrix projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(45), 800f / 480f, 0.1f, 600f);

        public Simulation(IntPtr drawSurface)
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            this.drawSurface = drawSurface;
            graphics.PreparingDeviceSettings +=
            new EventHandler<PreparingDeviceSettingsEventArgs>(graphics_PreparingDeviceSettings);
            System.Windows.Forms.Control.FromHandle((this.Window.Handle)).VisibleChanged +=
            new EventHandler(Simulation_VisibleChanged);
        }

        void graphics_PreparingDeviceSettings(object sender, PreparingDeviceSettingsEventArgs e)
        {
            e.GraphicsDeviceInformation.PresentationParameters.DeviceWindowHandle =
            drawSurface;
        }

        private void Simulation_VisibleChanged(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Control.FromHandle((this.Window.Handle)).Visible == true)
                System.Windows.Forms.Control.FromHandle((this.Window.Handle)).Visible = false;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            model = this.Content.Load<Model>(@"mode_uydu");
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            if (!customCamEnabled) view = Matrix.CreateLookAt(new Vector3(200, 200, 200), new Vector3(0, 0, 0), Vector3.UnitY);
            else {
                Vector3 camCartesianPos = SphericalToCartesian(cameraPos.X, (float)(Math.PI * cameraPos.Y / 180.0), (float)(Math.PI * cameraPos.Z / 180.0));
                
               view = Matrix.CreateLookAt(new Vector3(camCartesianPos.X, camCartesianPos.Y, camCartesianPos.Z), new Vector3(0, 0, 0), Vector3.UnitY);
            } 

            // TODO: Add your drawing code here
            positionMatrix = Matrix.CreateFromYawPitchRoll((float)(Math.PI * ((angleZ + modAngleZ) / 180.0)), (float)(Math.PI * ((angleX + modAngleX) / 180.0)), (float)(Math.PI * ((angleY + modAngleY) / 180.0))) * Matrix.CreateTranslation(position);
            //positionMatrix = Matrix.CreateRotationX((float)(Math.PI * ((angleX+modAngleX) / 180.0))) * Matrix.CreateRotationY((float)(Math.PI * ((angleY+modAngleY) / 180.0))) * Matrix.CreateRotationZ((float)(Math.PI * ((angleZ + modAngleZ) / 180.0))) * Matrix.CreateTranslation(position);

            DrawModel(model, positionMatrix, view, projection, gameTime);

            base.Draw(gameTime);
        }
        private void DrawModel(Model model, Matrix modelTranslation, Matrix view, Matrix projection, GameTime time)
        {
            Matrix[] transforms = new Matrix[model.Bones.Count];
            model.CopyAbsoluteBoneTransformsTo(transforms);
            foreach (ModelMesh mesh in model.Meshes)
            {
                foreach (BasicEffect effect in mesh.Effects)
                {
                    /*
                    switch (mesh.ParentBone.Index)
                    {
                        case 398:
                            effect.World = transforms[mesh.ParentBone.Index] * Matrix.CreateRotationY((float)(Math.PI * (0.5 * time.TotalGameTime.TotalSeconds))) * modelTranslation;
                            break;
                        case 37:
                            effect.World = transforms[mesh.ParentBone.Index] * Matrix.CreateRotationY((float)(Math.PI * (-0.5 * time.TotalGameTime.TotalSeconds))) * modelTranslation;
                            break;
                        default:
                            effect.World = transforms[mesh.ParentBone.Index] * modelTranslation;
                            break;
                    }
                    */
                    effect.World = modelTranslation;
                    effect.View = view;
                    effect.Projection = projection;
                    effect.LightingEnabled = true;
                    effect.EnableDefaultLighting();
                    effect.PreferPerPixelLighting = true;
                }

                mesh.Draw();
            }
        }

        private static Vector3 SphericalToCartesian(float radius, float polar, float elevation)
        {
            Vector3 outCart = new Vector3();
            float a = radius * (float) Math.Cos(elevation);
            outCart.X = a * (float) Math.Cos(polar);
            outCart.Y = radius * (float) Math.Sin(elevation);
            outCart.Z = a * (float) Math.Sin(polar);
            return outCart;
        }

    }
}
