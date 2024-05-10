
namespace Prova.CoresPrimarias {
    public class Branco {
        public Red Red { get; set; }
        public Green Green { get; set; }
        public Blue Blue { get; set; }
        public Branco() {
            Red = new Red(255);
            Green = new Green(255);
            Blue = new Blue(255);
        }
    }
}