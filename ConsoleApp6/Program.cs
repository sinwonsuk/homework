// See https://aka.ms/new-console-template for more information
Console.WriteLine("dsd");

//숙제 1 

//int[] Arr = { 1, 2, 3, 4, 5 }; 

// 숙제 2

//int Number = 3;

// for (int i = 1; i <= 100; i++)
//{
//    if(Number == i)
//    {
//        Console.WriteLine(Number);
//        Number += 3;
//    }

//}


// 숙제 3

//for (int i = 1; i < 10; i++)
//{
//	for (int j = 1; j < 10; j++)
//	{
//        Console.WriteLine("{0} * {1} = {2}",i,j,i*j );

//        if(j==9)
//        {
//            Console.WriteLine("");
//        }
//    }
//}

// 숙제 4 

//using System.Text;
//using System.Threading;

//Console.WriteLine("숫자를 입력해주세요");







//string input = Console.ReadLine();

//Console.WriteLine("입력한 값은 " + input + " 입니다.");

//Thread.Sleep(1000);

//int Number = 0;

//if(input != null)
//{
//    Number = int.Parse(input);
//}
//int multiply = 0;


////bool a = Console.ReadKey();


//bool check = int.TryParse(input, out Number);




//while (true)
//{

//    if (Console.KeyAvailable)
//    {
//        Console.WriteLine("숫자를 입력해주세요");

//        string Finish = Console.ReadLine();

//        if(Finish == "99999")
//        {
//            Console.WriteLine("종료 되었습니다");
//            break;
//        }
//        else
//        {
//            Console.WriteLine("다시 입력해주세요 ");
//            Thread.Sleep(1000);
//        }



//    }
//    if (check ==true)
//    {
//        multiply += 1;

//        int Value =  Number * multiply;
//        Console.WriteLine(Value);     
//    }

//    else if(check ==false) 
//    {
//        Console.WriteLine("잘못 입력 하였습니다");
//        break; 
//    }




//}

// 숙제 5 


//for (int i = 9; i > 0; i--)
//{
//	for (int j = 9; j > 0; j--)
//	{
//        Console.WriteLine("{0} * {1} = {2}",i,j,i*j );

//        if(j==1)
//        {
//            Console.WriteLine("");
//        }
//    }
//}

// 숙제 6 


//using System.Text;

//StringBuilder Message = new StringBuilder("1",10);



//int Number = 1;

//int Number_02 = 0;

//while (true)
//{
//    Console.WriteLine("값을 입력해주세요");

//    string input = Console.ReadLine();





//    if(input == Message.ToString())
//    {
//        Number++;

//        int Prev_Number = Number - 1;


//        if (Message.ToString() == "짝")
//        {
//            Message.Replace("짝", Number.ToString());
//        }
//        else
//        {
//            Message.Replace(Prev_Number.ToString(), Number.ToString());
//        }

//        if (Number <= 9)
//        {
//            if (Number == 3)
//            {
//                Message.Replace(Number.ToString(), "짝");    
//            }

//            if (Number == 6)
//            {
//                Message.Replace(Number.ToString(), "짝");
//            }

//            if (Number == 9)
//            {
//                Message.Replace(Number.ToString(), "짝");
//            }
//        }

//        else
//        {
//            Number_02++; 

//            if(Number_02==4)
//            {
//                Message.Replace(Number.ToString(), "짝");

//            }
//            if (Number_02 == 7)
//            {
//                Message.Replace(Number.ToString(), "짝");

//            }
//            if (Number_02 == 10)
//            {
//                Message.Replace(Number.ToString(), "짝");

//                Number_02 = 0;
//            }
//        }
//    }
//    else
//    {
//        Console.WriteLine("게임을 종료합니다");

//        break;
//    }
//}


