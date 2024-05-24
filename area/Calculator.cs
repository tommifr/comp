
class Calculator{

    public void calculateArea(){

    float number;
    
        while (!float.TryParse(Console.ReadLine(), out number) || number <= 0)// kollar inputen ser till att det är et positivt tal
        
        {
         Console.Write("Ogiltig inmatning. Vänligen ange ett positivt tal ");
        }

        if(number%3==0)//kollar om talet är delat med tre. och om det är det så får man ett easter egg
        {
            Console.WriteLine("Wow epic easter egg ditt tal är delbart med 3");
        }
      

    Console.WriteLine(number*number*MathF.PI);//gör matte
}

}
