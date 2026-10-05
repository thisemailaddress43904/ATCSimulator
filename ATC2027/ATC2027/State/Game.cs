using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;
using System.Linq;
using ATC2027.Forms;
using ATC2027.ATC_Library.CollectionRing;
using System;
using Microsoft.Xna.Framework.Input;
using ATC2027.ATC_Library.Airfield;

namespace ATC2027.State
{
    public class Game : AState
    {
        #region game        
        int indexOfSelectedPlane = -1;
        CollectionRing cr;
        #endregion

        Airfield airfield;

        #region forms
        ApplyClearanceForm acf;
        TimeSpan formUpdateFrequency = TimeSpan.FromSeconds(1);
        TimeSpan formLastUpdate = TimeSpan.Zero;

        AddPlane addPlaneForm;
        private TimeSpan collectionRingUpdateFrequency = TimeSpan.FromSeconds(1);
        #endregion


        
        //private Runway runway = new Runway("9", "27", 100f, Runway.runwayTexture, Constants.getArial_7());

        public override string getName => this.GetType().Name;

        public Game(ICollection<Plane>? planeList = null)
        {
            
            planeList ??= new List<Plane>(); 

            this.cr = new CollectionRing();

            foreach (Plane plane in planeList) { cr.AddPlane(plane); }

            //set up the aircraft collection ring form
            IList<StatusBoardItem> statusBoardItemList = [];

            foreach (var item in cr.getAircraftCollectionRingListItemsAsList())
                statusBoardItemList.Add(item);

            addPlaneForm = new AddPlane(ref cr);
            addPlaneForm.Show();

            acf = new ApplyClearanceForm(ref cr);
            acf.Show();

            airfield = AirfieldFactory.BuildLondonHeathrow();
        }

        public bool formShouldBeUpdated => cr.planeCollection.Values.Any(x => x.getAttributesHaveBeenUpdated());

        public override void Draw(GameTime gameTime, SpriteBatch spriteBatch)
        {
            
            foreach (var plane in cr.planeCollection) 
                plane.Value.Draw(gameTime, spriteBatch);
            
            airfield.Draw(gameTime, spriteBatch);

            base.Draw(gameTime, spriteBatch);
        }
        
        public override void Update(GameTime gameTime)
        {

            if (!(cr is null) && gameTime.TotalGameTime - cr.getLastUpdate() > collectionRingUpdateFrequency)
                cr.Update(gameTime);

            if (gameTime.TotalGameTime - formLastUpdate > formUpdateFrequency)
            {
                formLastUpdate = gameTime.TotalGameTime;
            }
            
            if (cr.planeCollection.Count == 0)
            {
                indexOfSelectedPlane = cr.planeCollection.Count - 1;
            }
            airfield.Update(gameTime);    
            foreach(var plane in cr.planeCollection)
                plane.Value.Update(gameTime);

            
            //Testing heading alterations and movement changes.
            Plane selectedPlane = GetSelectedPlane();
            
            if (selectedPlane != null) {
                bool leftArrowDown = Constants.getKeyboardState().IsKeyDown(Keys.Left);
                bool rightArrowDown = Constants.getKeyboardState().IsKeyDown(Keys.Right);

                if (leftArrowDown)
                    selectedPlane.DecrementHeading();
                else if (rightArrowDown)
                    selectedPlane.IncrementHeading();
            }

            //runway.Update(gameTime);

            base.Update(gameTime);
        }
        /// <summary>
        /// Returns the selected plane which is determined by the variable planeCollection and indexOfSelectedPlane. 
        /// If these values are not compatible and cause an exception to be thrown, null is returned
        /// </summary>
        /// <returns></returns>
        private Plane? GetSelectedPlane()
        {
            if (indexOfSelectedPlane < 0)
                return null;
            var planeCollectionAsIndex = cr.planeCollection.Values.ToArray();
            
            if (planeCollectionAsIndex.Length < indexOfSelectedPlane)
                return null;

            return planeCollectionAsIndex[indexOfSelectedPlane];
            
        }

        public void AddPlane(Plane plane)
        {
            this.cr.AddPlane(plane);
            //alterClearance.PopulateDataGridView(planeList);
        }
        public void RemovePlane(Plane plane)
        {
            this.cr.RemovePlane(plane);
        }

        public override string getDevModeDrawableString()
        {
            return $"{cr.getDevModeDrawableString()}";
        }
    }
}