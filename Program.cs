using System;
class Program {
    static void Main(string[]args){
        int MaxCo = 100;
        double[] x, y;
        x = new double[MaxCo];
        y = new double[MaxCo];

        int i;
        for(i=0; i<MaxCo;i++){
            double X, Y; 
            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());
            if(X != 0 || Y != 0){
                x[i] = X;
                y[i] = Y;
            }
            else{
                break;
            }
        }
        double Kx, Ky;
        Kx = double.Parse(Console.ReadLine());
        Ky = double.Parse(Console.ReadLine());

        int u = i-1;
        bool inside = true;
        for(i =0; i< u;i++){
            if (((y[i] > Ky) != (y[u] > Ky)) && (Kx < (x[u] - x[i]) * (Ky - y[i]) / (y[u] - y[i]) + x[i]) || Kx == 0 && Ky == 0) {
                inside = !inside;
            }
            u = i;
        }
        if(inside){
            Console.WriteLine("inside");
        }
        else{
            Console.WriteLine("outside");
        }
    }
}
