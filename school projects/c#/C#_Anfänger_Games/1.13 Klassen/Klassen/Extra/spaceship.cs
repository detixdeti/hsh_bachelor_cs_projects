using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassen.Extra
{
    class spaceship
    {
        public string name;
        public float energie;
        public float shield;
        public float speed;
        
        public spaceship(string name,float energie, float shield, float speed)
        {
            this.name = name;
            this.energie = energie;
            this.shield = shield;
            this.speed = speed;
        }
        
    }
}
