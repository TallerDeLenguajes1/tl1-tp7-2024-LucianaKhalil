namespace EspacioCalculadora{//organizador logico
    public class Calculadora{

        
        private double dato;

        public double Resultado{//propiedad para acceder a el dato si esta privado
            get => dato;            
        }
        public void sumar(double termino){
            dato+=termino;
        }
         public void restar(double termino){
            dato-=termino;
        }
        public void multiplicar(double termino){
           dato*=termino;
        }
        public void dividir(double termino){
        if(termino!=0){
             dato/=termino;
        }else{
            Console.WriteLine("No se puede dividir por 0");
        }
        }
}


}
