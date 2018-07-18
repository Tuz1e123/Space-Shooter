using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter
{
    class GameObject
    {
        #region Fields
        protected internal Texture2D myTexture;
        protected internal Vector2
            myPosition,
            myDestination,
            myRotationOrigin,
            myMouseLocation;

        protected internal Rectangle
            myHitbox;

        protected internal float
            myVelocity,
            myRotation,
            myScale = 1f,
            myBulletDelay,
            myBulletDelayOrigin,
            myBulletVelocity,
            myMovementTimer;

        protected internal bool
            myVisible,
            myMoving;

        protected internal int
            myCollisionDamage,
            myBulletDamage,
            myHealth;

        protected internal Color
            myColour = Color.White;
        #endregion

        #region Methods
        public virtual void Update(GameTime aTime)
        {
            //Blank for now.
        }

        public virtual void Draw(SpriteBatch aBatch)
        {
            //Blank for now.-
        }
        #endregion
    }
}
