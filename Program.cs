class Program {
    static void Main(string[] args) {
        Console.Write("Please input Number: ");
        int Number = int.Parse(Console.ReadLine());
        Console.Write("Please input AG: ");
        string AG = (Console.ReadLine());

        if (Number >= 100000 && Number <= 999999) {
        
        int total100000 = Number / 100000;
        Number = Number - (total100000 * 100000);

        int total10000 = Number / 10000;
        Number = Number - (total10000 * 10000);

        int total1000 = Number / 1000;
        Number = Number - (total1000 * 1000);

        int total100 = Number / 100;
        Number = Number - (total100 * 100);

        int total10 = Number / 10;
        Number = Number - (total10 * 10);

        int total1 = Number / 1;
        Number = Number - (total100 * 1);

        if ((AG == "CIA")) {
            if((total1 % 3 == 0) && (total10 != 1 || total10 != 3 || total10 != 5) && (total1000 >= 6 && total1000 !=8)) {
                Console.WriteLine("True");
            }else {

            Console.WriteLine("False");
        }
        } else if((AG == "FBI")){
            if((total100000 >= 4 && total100000 <= 7) && (total100 % 2 == 0 && total100 != 6) && (total10000 == 1 ||total10000 == 3 || total10000 == 5 || total10000 == 7 || total10000 == 9)) {
                Console.WriteLine("True");
            }else {

            Console.WriteLine("False");
        }
        } else if((AG == "NSA")){
            if((total1 == 1 || total1 == 2 || total1 == 3 || total1 == 5 || total1 == 6) && (total100 % 3 == 0 || total100 % 2 != 0) && 
            (total1 == 7 || total10 == 7 || total100 == 7 || total1000 == 7 || total10000 == 7 || total100000 == 7)) {
                Console.WriteLine("True");
            }else {

            Console.WriteLine("False");
        }
        }

        }else {

            Console.WriteLine("False");
        }
        
    }
}