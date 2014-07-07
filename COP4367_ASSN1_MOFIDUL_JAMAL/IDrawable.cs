using System;
namespace COP4367_ASSN1_MOFIDUL_JAMAL
{
    public abstract class  IDrawable
    {
        public bool IsAlive = true;
        public abstract void Draw(System.Drawing.Graphics graphicsContext);
        public abstract void Update();
    }
}
