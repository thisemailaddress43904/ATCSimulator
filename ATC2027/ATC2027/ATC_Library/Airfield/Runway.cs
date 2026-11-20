using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.Controls;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ATC2027.ATC_Library.Airfield
{
    public class Runway : IRunway, IComponent
    {
        Text text;

        Circle transitionPoint;

        Vector2 textLocation;
        
        string runwayName;
        IHeading runwayHeading;
        private Vector2 runwaySpawnPoint;

        public Runway(string runwayName, IHeading runwayHeading, Vector2 runwaySpawnPoint, Vector2 textLocation)
        {
            this.runwayName = runwayName;
            this.runwayHeading = runwayHeading;
            this.runwaySpawnPoint = runwaySpawnPoint;
            this.textLocation = textLocation;

            text = new Text(runwayName, Constants.getArial_7(), textLocation);
            transitionPoint = new Circle(runwaySpawnPoint, 2, Color.Red, Constants.getGraphicsDevice());
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            text.Draw(gameTime, spriteBatch);

            if (Constants.DevMode)
            {
                transitionPoint.Draw(gameTime, spriteBatch);
            }

        }
        public void Update(GameTime gameTime)
        {

        }

        public string getShorthandName()
        {
            return this.runwayName;
        }

        public Vector2 getSpawnPoint()
        {
            return runwaySpawnPoint;
        }

        public IHeading getHeading()
        {
            return this.runwayHeading;
        }
    }
}