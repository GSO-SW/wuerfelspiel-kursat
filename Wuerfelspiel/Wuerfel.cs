using System;

namespace Wuerfelspiel
{
    public class Wuerfel
    {
        private int seiten;
        public Wuerfel(int seiten){
            this.seiten = seiten;
            }

        public int Seiten { get { return seiten; } }
    }
}
