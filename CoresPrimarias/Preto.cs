
namespace Prova.CoresPrimarias {
    public class Preto {
        public Red Red { get; set; }
        public Green Green { get; set; }
        public Blue Blue { get; set; }
        public Preto() {
            Red = new Red(0);
            Green = new Green(0);
            Blue = new Blue(0);
        }
    }
}
