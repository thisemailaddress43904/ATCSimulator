using ATC2027.ATC_Library.ControlAttribute.Heading;
using ATC2027.Controls;
using ATC2027.Interfaces;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ATC2027.ATC_Library.Airfield
{
    public class Runway : IRunway, IComponent
    {
        SpriteFont sf;
        private string? runwayName2;
        Color runwayColor;
        string runwayName1;
        Texture2D runway;
        private SpriteFont spriteFont;
        Vector2 runwayOrigin;
        float headingInRadiansToDrawRunwayTexture;
        public static Texture2D runwayTexture;
        Vector2 position;
        Vector2 textPosition1;
        private Vector2 textPosition2;

        public Runway(string runwayName1, string? runwayName2, Heading heading, Texture2D runwayTexture, SpriteFont sf, Vector2 position)
        {
            this.spriteFont = sf;
            this.runwayOrigin = new Vector2(runwayTexture.Width / 2, runwayTexture.Height / 2);
            this.runway = runwayTexture;
            this.runwayName1 = runwayName1;
            this.runwayName2 = runwayName2;
            this.runwayColor = Color.White;
            this.headingInRadiansToDrawRunwayTexture = (float)double.DegreesToRadians(heading.GetHeadingInFloatDegrees() + 90);
            this.position = position;
            this.textPosition1 = new Vector2(position.X - this.runway.Width / 2, position.Y + sf.MeasureString("!").Y);
            this.textPosition2 = new Vector2(position.X + this.runway.Width / 2 + sf.MeasureString(runwayName2).X*1.5f, position.Y + sf.MeasureString("!").Y);
        }

        public static class RunwayListFactory
        {
            public static IList<Runway> BuildFromListOfHeadings(IList<Tuple<Heading, IList<string>>> runwayData)
            {
                IList<Runway> runwayList = [];
                int yPosition = Constants.getHeightOfScreen / 2;
                foreach (var runwayDatum in runwayData)
                {
                    if (runwayDatum.Item2 == null)
                        return [];
                    if (runwayDatum.Item2.Count > 2)
                        return [];
                    if (runwayDatum.Item2.Count == 0)
                        return [];

                    string runway1Name = runwayDatum.Item2[0];
                    string? runway2Name = null;
                    if (runwayDatum.Item2.Count == 2)
                        runway2Name = runwayDatum.Item2[1];

                    

                    runwayList.Add(new Runway(runway1Name,runway2Name,runwayDatum.Item1, Runway.runwayTexture, Constants.getArial_7(), new Vector2(Constants.getWidthOfScreen/2, yPosition)));
                    yPosition += Runway.runwayTexture.Width + Airfield.spacingBetweenRunways;
                }



                return runwayList;

            }
        }

        public void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(runway,
                position,
                null,
                runwayColor,
                headingInRadiansToDrawRunwayTexture,
                runwayOrigin,
                1,
                SpriteEffects.None, 
                0f);

            Text.StaticDraw(spriteBatch, $"{this.getShorthandName1()}", spriteFont, textPosition1, Color.Blue, 0, 1.5f);
            
            if (this.runwayName2 != null)
                Text.StaticDraw(spriteBatch, $"{this.getShorthandName2()}", spriteFont, textPosition2, Color.Blue, 0, 1.5f);

        }

        public string getShorthandName1()
        {
            return runwayName1;
        }

        public void Update(GameTime gameTime)
        {

        }
        public string getShorthandName2()
        {
            return runwayName2;
        }

        public static class Factory
        {
            public static Runway? build(float heading, string runwayName)
            {
                //00 - 350 inclusive regex followed by '' 'l' 'c' 'r'
                //300-360
                Regex regexA = new Regex("^[3][0-5][lcr]*$");
                //100-290
                Regex regexB = new Regex("^[1-2][0-9][lcr]*$");
                //0-90
                Regex regexC = new Regex("^[0-9][lcr]*$");

                if (regexA.IsMatch(runwayName) || regexB.IsMatch(runwayName) || regexC.IsMatch(runwayName))
                    return new Runway(runwayName, null, new Heading(heading), Runway.runwayTexture, Constants.getArial_7(), new Vector2(Constants.getWidthOfScreen / 2, Constants.getHeightOfScreen / 2));
                else
                    return null;
            }

            internal static IRunway build(string text1, string text2)
            {
                throw new NotImplementedException();
            }
        }
    }
}