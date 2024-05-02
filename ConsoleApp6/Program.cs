// See https://aka.ms/new-console-template for more information
using System;
using System.Data.Common;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Numerics;
using System.Security.AccessControl;
using System.Text;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Console.WriteLine("dsd");

//숙제 1 
// 당첨 
//Random random = new Random();

//StringBuilder Str = new StringBuilder();

//int Check = 0;

//for (int i = 0; i < 7; i++)
//{
//    int Num = random.Next(2);

//    if (Num == 0)
//    {
//        Str.Append('1');
//    }
//    else
//    {
//        Str.Append('7');
//        Check++;
//    }
//}

//Console.WriteLine(Str.ToString());

//if (Check == 3)
//{ 
//    Console.WriteLine("당첨입니다");
//}
//else
//{    
//    Console.WriteLine("꽝입니다");
//}
// 숙제 2 
// 가위바위 보 

//Random random = new Random();
//StringBuilder Str = new StringBuilder();
//Str.Capacity = 5;
//while (true)
//{
//    Console.WriteLine("가위 바위 보 중 입력해주세요");
//    String Turn = Console.ReadLine();

//    int Num = random.Next(3);

//    if (Num == 0)
//    {
//        Str.Append("가위");
//    }
//    else if (Num == 1)
//    {
//        Str.Append("바위");
//    }
//    else
//    {
//        Str.Append("보");
//    } 
//    switch (Turn)
//    {
//        case "가위":
//        {
//            if (Str.ToString() == "바위")
//            {
//                Console.WriteLine("졌습니다");
//                break;
//            }
//            else if (Str.ToString() == "보")
//            {
//                Console.WriteLine("이겼습니다");
//                break;
//            }
//            else
//            {
//                Console.WriteLine("무승부 입니다");
//                break;
//            }
//        }
//        case "바위":
//        {
//            if (Str.ToString() == "가위")
//            {
//                Console.WriteLine("이겼습니다");
//                break;
//            }
//            else if (Str.ToString() == "보")
//            {
//                Console.WriteLine("졌습니다");
//                break;
//            }
//            else
//            {
//                Console.WriteLine("무승부 입니다");
//                break;
//            }

//        }
//        case "보":
//        {
//            if (Str.ToString() == "가위")
//            {
//                Console.WriteLine("졌습니다");
//                break;
//            }
//            else if (Str.ToString() == "바위")
//            {
//                Console.WriteLine("이겼습니다");
//                break;
//            }
//            else
//            {
//                Console.WriteLine("무승부 입니다");
//                break;
//            }
//        }
//        default:
//            break;
//    }
//    Str.Clear();
//    Console.WriteLine("다시");
//}

// 숙제 3 숫자를 입력받아 거꾸로 출력
//Console.WriteLine("숫자를 입력해주세요");

//string Num_String = Console.ReadLine();

//int Num = int.Parse(Num_String);

//for (int i = Num; i > 0; i--)
//{
//    Console.Write(i+ " ");
//}

// 숙제 4 2개의 숫자를 입력받아 그사이의 값 출력 

//Console.WriteLine("첫 번쨰 숫자를 입력해주세요");

//string Num_String_01 = Console.ReadLine();

//int Num_01 = int.Parse(Num_String_01);

//Console.WriteLine("두 번쨰 숫자를 입력해주세요");

//string Num_String_02 = Console.ReadLine();

//int Num_02 = int.Parse(Num_String_02);

//for (int i = Num_01; i <= Num_02; i++)
//{
//    Console.Write(i+ " ");
//}

// 숙제 5 공차 


//Console.WriteLine("첫 번쨰 숫자를 입력해주세요");

//string Num_String_01 = Console.ReadLine();

//int Num_01 = int.Parse(Num_String_01);

//Console.WriteLine("공차를 입력해주세요");

//string Num_String_02 = Console.ReadLine();

//int Num_02 = int.Parse(Num_String_02);

//for (int i = 0; i < 10; i++)
//{
//    Console.Write(Num_01 + Num_02 * i + " ");
//}

// 숙제 6 1~1000 까지 10의 배수로만 

//for (int i = 0; i <= 1000; i+=10)
//{
//    Console.Write(i + " ");
//}

// 숙제 7 영문 소문자인지 확인 

//Console.WriteLine("영문을 입력해주세요");

//string Str = Console.ReadLine();

//char One_Str = char.Parse(Str);

//if(Char.IsLower(One_Str))
//{
//    Console.WriteLine("영문 소문자 입니다");
//}
//else
//{
//    Console.WriteLine("영문 소문자가 아닙니다");
//}

// 숙제 8 더큰수 출력 


//Console.WriteLine("첫 번쨰 숫자를 입력해주세요");

//string Num_String_01 = Console.ReadLine();

//int Num_01 = int.Parse(Num_String_01);

//Console.WriteLine("두 번쨰 숫자를 입력해주세요");

//string Num_String_02 = Console.ReadLine();

//int Num_02 = int.Parse(Num_String_02);

//Console.WriteLine("");

//if (Num_01 > Num_02)
//{
//    Console.WriteLine(Num_01);
//}
//else if (Num_01 < Num_02)
//{
//    Console.WriteLine(Num_02);
//}
//else
//{
//    Console.WriteLine(Num_01 + " " + Num_02);
//}

// 숙제 9 학점 출력

//Console.WriteLine("0~100 숫자를 입력해주세요");

//string Score = Console.ReadLine();

//int Num = 0;

//bool check = int.TryParse(Score, out Num);

//if(check ==true)
//{
//    if (Num >=101 || Num < 0)
//    {
//        Console.WriteLine("비정상적인 숫자입니다");
//    }
//    else if(Num >= 91)
//    {
//        Console.WriteLine("A입니다");
//    }
//	else if(Num >= 81)
//    {
//        Console.WriteLine("B입니다");
//    }
//    else if (Num >= 71)
//    {
//        Console.WriteLine("C입니다");
//    }
//    else if (Num >= 61)
//    {
//        Console.WriteLine("D입니다");
//    }
//    else if (Num >= 0)
//    {
//        Console.WriteLine("F입니다");
//    }
//}
//else
//{
//    Console.WriteLine("숫자를 잘못 입력하였습니다");
//}

// 숙제 10 배열의 5개 값을 입력받아 저장하고 그중에 홀수를 찾아 2를 곱한 값으로 변경해라 

//int[] Arr = new int[5];

//for (int i = 0; i < Arr.Length; i++)
//{
//    Console.WriteLine("숫자를 입력해주세요");

//    string Num_Str = Console.ReadLine();

//    int Num = int.Parse(Num_Str);

//    if (Num % 2 == 1)
//    {
//        Arr[i] = Num*2;
//    }
//    else
//    {
//        Arr[i] = Num;
//    }

//}
//Console.WriteLine("결과물");

//for (int i = 0;i < Arr.Length;i++)
//{
//    Console.Write(Arr[i]+ " ");
//}

// 숙제 12 for문을 이용하여 0 부터 10 미만의 정수 중에서 짝수만을 작은 수부터 출력하시오 

//for (int i = 2; i <= 10; i+=2)
//{
//    Console.Write(i + " ");
//}

// 숙제 13  while 문을 이용하여 0부터 10 미만의 정수 중에서 홀수만을 큰수부터 출력하시오 

//int Num = 10;

//while (true)
//{
//    if(Num % 2 == 1)
//    {
//        Console.Write(Num + " ");
//    }

//    Num--;

//    if(Num == 0)
//    {
//        break;
//    }
//}

// 숙제 14 1부터 20 미만의 정수중에서 2 또는 3의 배수가 아닌 수의 총합을 구하시오 

//for (int i = 0; i < 20; i++)
//{
//    if(i % 2 !=0)
//    {
//        if(i % 3 != 0)
//        {
//            Console.Write(i + " ");
//        }
//    }
//}

// 숙제 15 2개의 주사위를 던졌을떄 눈의 합이 6이 되는 모든 경우의 수를 출력하시오 
// 그냥 이걸 뛰우라는 건가? 
// {1,5} ,{2,4} , {3,3} , {4,2} , {5,1}
// 근데 그냥 출력해도 되는 건데?

//for (int i = 0; i < 6; i++)
//{
//    for (int j = 0; j < 6; j++)
//    {
//        if( i + j == 6)
//        {
//            Console.WriteLine(i + " " + j);
//            continue;
//        }
//    }
//}

// 숙제 16 2의 배수인지 아닌지 출력해라 단 입력받은 것이 숫자가 아닐경우 숫자가 아닙니다를 출력하십시오 


//Console.WriteLine("숫자를 입력해주세요");

//string Num_String = Console.ReadLine();

//int Num = 0;

//bool check = int.TryParse(Num_String, out Num);

//if(check ==true)
//{
//    if(Num >= 2)
//    {
//        if (Num % 2 == 0)
//        {
//            Console.WriteLine("2의 배수입니다");
//        }
//        else
//        {
//            Console.WriteLine("2의 배수가 아닙니다");
//        }
//    }

//    else
//    {
//        Console.WriteLine("2의 배수가 아닙니다");
//    }
//}
//else
//{
//    Console.WriteLine("숫자가 아닙니다");
//}

// 문제 17 행렬의 곱을 계산하시오 

//int[,] A = new int[2,2];
//int[,] B = new int[2, 2];
//int[,] Value = new int[2, 2];
//for (int k = 0; k < 2; k++)
//{
//    for (int i = 1; i < 3; i++)
//    {
//        for (int j = 1; j < 3; j++)
//        {
//            Console.WriteLine("{0}행 {1}열을 입력해주세요", i, j);

//            String Str_Num = Console.ReadLine();

//            int Num = int.Parse(Str_Num);

//            if (k == 0)
//            {
//                A[i - 1, j - 1] = Num;
//            }

//            if (k == 1)
//            {
//                B[i - 1, j - 1] = Num;
//            }
//        }
//    }

//}

//Value[0, 0] = A[0, 0] * B[0, 0] + A[0, 1] * B[1, 0];
//Value[0, 1] = A[0, 0] * B[0, 1] + A[0, 1] * B[1, 1];
//Value[1, 0] = A[1, 0] * B[0, 0] + A[1, 1] * B[1, 0];
//Value[1, 1] = A[1, 0] * B[0, 1] + A[1, 1] * B[1, 1];

//for (int i = 0; i < 2; i++)
//{
//    for(int j = 0;j <2; j++)
//    {
//        Console.Write(Value[i,j]+ " ");
//    }
//    Console.WriteLine();
//}

// 문제 18 배열을 거꾸로 출력시키기 배열을 사용해 6개의 숫자를 입력받고 ​6개의 숫자를 거꾸로 출력시키는예제를 만들어 보세요.
// 

//int[] Arr = new int[6];

//for (int i = 0; i < Arr.Length; i++)
//{
//    Console.WriteLine("값을 입력해주세요");

//     String Str_Num = Console.ReadLine();

//    int Num = int.Parse(Str_Num);

//    Arr[i] = Num;
//}

//for (int i = Arr.Length; i > 0;i--)
//{
//    Console.WriteLine(Arr[i-1]+ " ");
//}



// 문제 19 배열을 사용해 홀수와 짝수를 구분해 출력시키기

//int[] odd_number = new int[5];
//int[] Even_number = new int[5];

//int A = -1;
//int B = -1;

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("값을 입력해주세요");

//    String Str_Num = Console.ReadLine();

//    int Num = int.Parse(Str_Num);

//    if(Num % 2 == 0)
//    {
//        A++;
//        Even_number[A] = Num;    
//    }
//    else
//    {
//        B++;
//        odd_number[B] = Num;
//    } 
//}


//for (int i = 0; i <= A; i++)
//{
//    Console.Write(Even_number[i] + " ");
//}
//Console.WriteLine();

//for (int i = 0; i <= B; i++)
//{
//    Console.Write(odd_number[i] + " ");
//}

// 문제 20 오름 차 순으로 정렬된 숫자 6개가 저장되는 배열을 선언해 주시고​

//숫자를 입력받았을 때 그 숫자가 배열 안에서 자기 자리를 찾아가는​

//프로그램을 만들어보세요.​


//int[] Arr = new int[6];

//for (int i = 0; i < Arr.Length-1; i++)
//{
//    Console.WriteLine("값을 입력해주세요");

//    String Str_Num = Console.ReadLine();

//    int Num = int.Parse(Str_Num);

//    Arr[i] = Num;

//}


//{
//    Console.WriteLine("중간에 넣을 값을 입력해주세요");
//    String Str_Num = Console.ReadLine();
//    int Num = int.Parse(Str_Num);
//    Arr[5] = Num;
//}

//for (int i = 0; i < Arr.Length; i++)
//{

//    for (int j = 0+i; j < Arr.Length; j++)
//    {
//        if (Arr[i] < Arr[j])
//        {

//        }
//        else if (Arr[i] > Arr[j])
//        {
//            int Prev_Num = Arr[i];

//            Arr[i] = Arr[j];

//            Arr[j] = Prev_Num;
//        }
//    }
//}

//for (int i = 0; i < Arr.Length; i++)
//{
//    Console.WriteLine(Arr[i] + " ");
//}


// 문제 21 사용자로부터 5개의 정수를 배열로 입력 받은 후 숫자 하나를 추가로 입력 받아 ​

//그 수가 배열에 몇개 존재하는 지를 출력하는 프로그램을 작성하시오.​


//int[] Arr = new int[5];

//for (int i = 0; i < Arr.Length; i++)
//{
//    Console.WriteLine("값을 입력해주세요");

//    String Str_Num = Console.ReadLine();

//    int Num = int.Parse(Str_Num);

//    Arr[i] = Num;
//}
//{
//    Console.WriteLine("찾을 값을 입력해주세요");

//    String Str_Num = Console.ReadLine();

//    int Num = int.Parse(Str_Num);

//    int Value = 0; 

//    for (int i = 0;i < Arr.Length;i++)
//    {
//        if (Arr[i] == Num) 
//        {
//            Value++;
//        }
//    }

//    Console.WriteLine(Value + "개 존재합니다");
//}

// 문제 22 1~5 사이의 랜덤한 값이 10개 저장된 배열에서 중복된 값이 제거된 배열을 만들어주세요.​

//int[] Arr = new int[10];
//int[] Arr_02 = new int[10];
//int[] Arr_03 = new int[10];
//int Index = 0;
//for (int i = 0; i < Arr.Length; i++)
//{
//    Random random = new Random();
//    int Num = random.Next(1,5);
//    Arr[i] = Num;
//}

//for (int i = 0; i < Arr.Length; i++)
//{
//    Console.Write(Arr[i] + " ");


//}

//Console.ReadLine();

//for (int i = 0; i < Arr.Length; i++)
//{
//    for (int j = 0; j < Arr.Length; j++)
//    {
//        if (Arr[i] == Arr[j])
//        {
//            Arr_02[j] = Arr[i];
//            break;
//        }
//    }       
//}

//for (int i = 0; i < Arr_02.Length; i++)
//{
//    if (Arr_02[i] != 0)
//    {
//        Arr_03[Index++] = Arr_02[i];
//    }
//}

//Array.Resize(ref Arr_03, Index);

//for(int i = 0; i < Arr_03.Length; i++)
//{
//    Console.Write(Arr_03[i] + " ");
//}

// 숙제 23 

//string[,] Arr = new string[3, 3];

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//       // string Str = Console.WriteLine("({0},{1})",i,j);

//        Arr[i, j] = "(" + i + "," + j + ")";
//    }
//}

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        Console.Write(Arr[i, j]);      
//    }
//    Console.WriteLine();
//}

// 숙제 24 

//int[,] Arr = new int[4, 4];

//int Num = 0;

//for (int i = 0; i < 4; i++)
//{

//	for (int j = 0; j < 4; j++)
//	{
//		Arr[i, j] = (i+1 + j+ Num);

//	}
//    Num += 3;
//}
//for (int i = 0; i < 4; i++)
//{
//	for(int j = 0;j < 4; j++)
//	{
//        Console.Write(Arr[i, j]+ " ");
//    }
//	Console.WriteLine();
//}

// 숙제 25

//int[,] Arr = new int[4, 4];
//Random ramdom = new Random(); 


//for (int i = 0; i < 4; i++)
//{
//    for (int j = 0; j < 4; j++)
//    {
//        if(j==3)
//        {
//            Arr[i, j] = Arr[i, 0]+ Arr[i, 1]+ Arr[i, 2];
//        }
//        else
//        {
//            int Num = ramdom.Next(1, 10);
//            Arr[i, j] = Num;
//        }
//    }
//}

//for (int i = 0;i < 4; i++)
//{
//    for(int j = 0;j < 4; j++)
//    {
//        Console.Write(Arr[i, j] + " ");
//    }
//    Console.WriteLine();
//}

// 숙제 26

//int Num = 0;
//int Num_02 = 0;
//bool Num_Check = false;

//void Check(String Letter, out int num)
//{
//    while (true)
//    {
//        Console.Write(Letter);

//        String Str_Num = Console.ReadLine();

//        Num_Check = int.TryParse(Str_Num, out num);

//        if (Num_Check == false)
//        {
//            Console.WriteLine("잘못 다시 입력해주세요");          
//        }
//        else if (num <= 0 || num > 10)
//        {
//            Console.WriteLine("잘못 다시 입력해주세요");     
//        }
//        else if(Num_Check == true)
//        {
//            break;
//        }
//    }


//}

//Random random = new Random();

//while (true)
//{
//  // 여기다 넣으면 계속 생성되나? Random random = new Random();


//    Check("행크기 : " , out Num);



//    Check("열크기 : ", out Num_02);



//    char[,] Arr = new char[Num, Num_02];

//    for (int i = 0; i < Num; i++)
//    {
//        for (int j = 0; j < Num_02; j++)
//        {
//            Arr[i, j] = (char)random.Next(65, 90);
//        }
//    }


//    for (int i = 0; i < Num; i++)
//    {
//        for (int j = 0; j < Num_02; j++)
//        {
//            Console.Write(Arr[i, j]+ " ");

//        }
//        Console.WriteLine();
//    }

//    break;

//}

// 숙제 27 

// 초기 설정 
//Console.Write("행의 크기 : ");

//String Str_Num = Console.ReadLine();

//int Num = int.Parse(Str_Num);

//char[][] Arr = new char[Num][];

//int ASCII = 97;


//// 반복 

//for (int i = 0; i < Num; i++)
//{
//    int num = 0;
//    Console.Write("{0}열의 크기 : ",i);

//    Str_Num = Console.ReadLine();

//    num = int.Parse(Str_Num);

//    Arr[i] = new char[num];
//}

//for (int i = 0; i < Num; i++)
//{
//    for (int j = 0; j < Arr[i].Length; j++)
//    {
//        Arr[i][j] = (char)ASCII;
//        ASCII++;
//    }
//}


//for (int i = 0; i < Num; i++)
//{
//    for (int j = 0; j < Arr[i].Length; j++)
//    {
//        Console.Write(Arr[i][j]+ " ");
//    }
//    Console.WriteLine();
//}

// 문제 1 매개 변수가 홀수인지 짝수인지 출력 시키는 함수 작성 

//int ad = 71;

//ada(ref ad);

//void ada(ref int Num)
//{



//    if (Num % 2 == 0)
//    {
//        Console.WriteLine("짝수입니다");

//    }
//    else
//    {
//        Console.WriteLine("홀수입니다");

//    }

//}

// 문제 2 두 정수를 매개변수로 넘겨 받아 나눗셈의 결과로 출력하는 함수 

//int Num = 10;
//int Num_02 = 2;

//Function(Num, Num_02);

//int Function(int A, int B)
//{
//    int Value = A / B;

//    Console.WriteLine(Value);
//    return Value;
//}

// 문제 3 매개변수로 정수 2개를 넘겨받아 두수사이에 정수의 합을 리턴하는 함수 

//int Num = 4;
//int Num_02 = 2;

//int a = Function(Num, Num_02);

//int Function(int A,int B)
//{
//    int Value = 0;

//    if (A == B)
//    {
//        Console.WriteLine("값은 값입니다");
//        return 0;
//    }

//    if(A < B)
//    {
//        for(int i = A; i <= B; i++) 
//        {
//            Value += i;
//        }
//    }

//    else if (A > B)
//    {
//        for (int i = B; i <= A; i++)
//        {
//            Value += i;
//        }
//    }

//    Console.WriteLine(Value);

//    return Value;
//}

// 문제 4 메소드를 정의 하여 입력받은 숫자를 거꾸로 뒤집는수를 출력 

//Function();

//void Function()
//{
//    Console.WriteLine("숫자를 입력하세요");

//    System.String Str_Num = Console.ReadLine(); 

//    int Num = int.Parse(Str_Num);

//    for (int i = Num; i > 0; i--)
//    {
//        Console.Write(i+" ");
//    }

//}
// 문제5 더큰수를 출력
//int Num = 10;
//int Num_02 = 5;


//Function(Num, Num_02);

//int Function(int Num,int Num_02)
//{
//    if(Num == Num_02)
//    {
//        Console.WriteLine("수가 같습니다");
//        return 0;
//    }
//    else if(Num > Num_02)
//    {
//        Console.WriteLine(Num);
//        return Num;
//    }
//    else if (Num < Num_02)
//    {
//        Console.WriteLine(Num_02);
//        return Num_02;
//    }
//    return 0;
//}

// 문제 6
//int Num = 10;
//int Num_02 = 10;
//int Num_03 = 10;

//Test(Num, Num_02, Num_03);  

//int Test(int a, int b, int c)
//{
//    int Value = 0;

//    Value = (a + b + c) / 3;


//    Console.WriteLine(Value);
//    return Value;
//}

// 문제 7
//int Num = 15;
//int Num_02 = 11;
//int Num_03 = 12;

//Test(Num, Num_02, Num_03);  


//// 7 //1 //5
//int Test(int a, int b, int c)
//{


//    //bool isEven;
//    //bool isEven_02;
//    //bool isEven_03;
//    //isEven = (a > b) ? true : false;
//    //isEven_02 = (a > c) ? true : false;
//    //isEven_03 = (b > c) ? true : false;


//    int sds = (a > b ? b : a) > c ? c : (a > b ? b : a);

//    Console.WriteLine(sds);
//    return sds;

//}

// 문제 8

//char str = 'D';
//test(str);
//char test(char Str)
//{
//    int Str_Num = str;

//    if(Str <= 122)
//    {
//        if(Str >= 97)
//        {

//            Console.WriteLine(str.ToString().ToUpper().ToCharArray());
//            return str.ToString().ToUpper().ToCharArray()[0];
//        }
//    }


//    if (Str <= 90)
//    {
//        if (Str >= 65)
//        {
//           // str.ToString().ToUpper();
//            Console.WriteLine(str.ToString().ToLower());
//            return str.ToString().ToLower().ToCharArray()[0];
//        }
//    }


//    return str;

//}

// 문제 9 

//int Num = 20;

//factor(Num);

//void factor(int num)
//{
//    int check = 0;

//    for (int i = 1; i< num; i++)
//    {
//        if (num % i == 0)
//        {
//            check = i;
//        }      
//    }

//    Console.WriteLine(check);
//}

//int a = 0;
//int b = 0;

//Console.Write("두 수를 입력 하시오 : ");

//string Str = Console.ReadLine();

//char[] arr = Str.ToCharArray();

//bool check = false;

//int[] Num = new int[10];
//int[] Num_02 = new int[10];

//int index = 0;
//int index_02 = 0;

//int test = 0;

//for (int i = 0; i < arr.Length; i++)
//{
//    if ((int)arr[i] >= 48)
//    {
//        if ((int)arr[i] <= 57)
//        {
//            if (check == true)
//            {
//                int d = int.Parse(arr[i].ToString());

//                Num_02[index] = d;
//                index++;

//            }

//            else if (check == false)
//            {
//                int d = int.Parse(arr[i].ToString());

//                Num[index_02] = d;
//                index_02++;
//            }

//            else
//            {
//                check = true;
//                continue;
//            }

//        }
//    }

//    else
//    {
//        check = true;
//        continue;
//    }

//}

//int Num_test = 1;

//for (int i = index_02-1; i >= 0; i--)
//{


//        a += Num_02[i] * Num_test;
//        Num_test *= 10;

//}

//Num_test = 1;

//for (int i = index-1; i >= 0; i--)
//{


//        b += Num[i] * Num_test;
//        Num_test *= 10;

//}


//Console.WriteLine(b);
//Console.WriteLine(a);



//gcd(a, b);

//int gcd(int a, int b)
//{

//    if(a> b)
//    {
//        for (int i = 1; i < a; i++)
//        {
//            if (a % i == 0)
//            {
//                if(b % i ==0)
//                {
//                    test = i;
//                }
//            }
//        }

//    }
//    else if (a < b)
//    {
//        for (int i = 1; i < b; i++)
//        {
//            if (a % i == 0)
//            {
//                if(b % i==0)
//                {
//                    test = i;
//                }
//            }
//        }

//    }
//    Console.Write("최대 공약수 값 : ");
//    Console.Write(test);

//    return test;
//}

//Account account = new Account();

//account.Atm();

//enum Interface
//{
//    check_money, //돈확인
//    Withdraw,// 인출
//    deposit,// 입금 


//}
//class Account
//{
//    Interface Interface;
//    private int money;


//    public void Atm()
//    {
//        while (true)
//        {
//            Console.WriteLine("1. 잔액 조회");
//            Console.WriteLine("2. 인출");
//            Console.WriteLine("3. 입금");
//            Console.WriteLine("4. 종료");

//            string Str_num = Console.ReadLine();

//            int num = int.Parse(Str_num);

//            if(num == 4)
//            {
//                return;
//            }



//            Interface = (Interface)num-1;


//            switch (Interface)
//            {
//                case Interface.Withdraw:
//                    {
//                        Console.Write("인출 할 금액을 입력해주세요 : ");
//                        System.String Str_Num = Console.ReadLine();
//                        int Num = int.Parse(Str_Num);

//                        if (Num > money)
//                        {
//                            Console.WriteLine("인출 할 금액이 너무 많습니다");

//                        }

//                        else if (Num < money)
//                        {
//                            Console.WriteLine("인출 되었습니다");
//                            money -= Num;
//                        }


//                    }
//                    break;
//                case Interface.deposit:
//                    {
//                        Console.Write("입금 할 금액을 입력해주세요 : ");
//                        System.String Str_Num = Console.ReadLine();
//                        int Num = int.Parse(Str_Num);


//                        money += Num;

//                    }
//                    break;
//                case Interface.check_money:
//                    {
//                        Console.WriteLine("잔액 : " + money);
//                    }
//                    break;
//                default:
//                    break;
//            }
//        }
//    }

//}
//Dog dog = new Dog();
//dog.Update();


//enum Interface
//{
//    walk,
//    eat,
//    sleep,
//}

//class Base_dog
//{
//    protected Interface Interface;

//    protected int height = 0;
//    protected int age = 0;
//    protected int weight = 0;
//    protected string name;

//    public void Walk()
//    {
//        Console.WriteLine(name + "이 걷습니다");
//        Console.WriteLine("몸무게가 빠집니다");
//        Console.WriteLine();
//      weight -= 1;
//    }

//    public void eat()
//    {
//        Console.WriteLine(name + "이 먹습니다");
//        Console.WriteLine("몸무게가 늘어납니다");
//        Console.WriteLine();
//        weight += 1;
//    }

//    public void Sleep()
//    {
//        Console.WriteLine(name + "이 잡니다");
//        age += 1;
//        Console.WriteLine("나이가 늘어납니다");
//        Console.WriteLine();

//    }
//}


//class Dog : Base_dog
//{
//    public Dog()
//    {
//        name = "진돗개";
//        age = 5;
//        weight = 20;
//        height = 60;
//    }

//    public Interface Interface { get; private set; }

//    public void State()
//    {
//        Console.WriteLine("이름 : " + name);
//        Console.WriteLine("나이 : " + age);
//        Console.WriteLine("몸무게 : " + weight);
//        Console.WriteLine("키 : " + height);
//    }

//    public void Update()
//    {
//        while (true)
//        {
//            State();

//            Console.WriteLine();


//            Console.WriteLine("1. 걷다");
//            Console.WriteLine("2. 먹다");
//            Console.WriteLine("3. 잔다");
//            Console.WriteLine("4. 종료");






//            string Str_num = Console.ReadLine();

//            int num = int.Parse(Str_num);

//            if(num == 4)
//            {
//                return;           
//            }


//            Interface = (Interface)num-1;

//            switch (Interface)
//            {
//                case Interface.walk:
//                    {
//                        Walk();
//                    }
//                    break;
//                case Interface.eat:
//                    {
//                        eat();
//                    }
//                    break;
//                case Interface.sleep:
//                    {
//                        Sleep();
//                    }
//                    break;
//                default:
//                    break;
//            }

//        }

//    }

//}


//Student student = new Student();
//student.Start();
//student.update();


//enum Interface
//{
//    walk=1,
//    eat,
//    sleep,
//    study,
//}


//class Student
//{
//    private Interface Interface;

//    private int Hp = 100;
//    private int Score = 10;
//    private int weight = 60;
//    private string name;

//    public void Start()
//    {
//        Console.Write("이름 : ");
//        System.String Nam = Console.ReadLine();

//        name = Nam;

//    }

//    public void State()
//    {
//        Console.WriteLine("이름 : " + name);
//        Console.WriteLine("점수 : " + Score);
//        Console.WriteLine("몸무게 : " + weight);
//        Console.WriteLine("체력 : " + Hp);
//    }


//    public void Walk()
//    {
//        if (Hp <= 20)
//        {
//            Console.WriteLine("체력이 없어서 운동할 수 없습니다");

//        }
//        else
//        {
//            Console.WriteLine(name + "가 운동합니다");
//            Console.WriteLine("몸무게가 빠집니다");
//            Console.WriteLine("체력이 떨어집니다");
//            Hp -= 20;
//            Console.WriteLine();
//            weight -= 1;
//        }

//    }

//    public void eat()
//    {
//        Console.WriteLine(name + "가 먹습니다");
//        Console.WriteLine("몸무게가 늘어납니다");
//        Console.WriteLine();
//        weight += 1;
//    }

//    public void Sleep()
//    {
//        Console.WriteLine(name + "가 잡니다");
//        Console.WriteLine("Hp가 회복됩니다");
//        Hp = 100;
//        Console.WriteLine();
//    }
//    public void Study()
//    {
//        if (Hp < 50)
//        {
//            Console.WriteLine("체력이 없어서 공부할 수 없습니다");
//        }
//        else
//        {
//            Console.WriteLine(name + "공부 합니다");
//            Console.WriteLine("점수가 오릅니다");
//            Console.WriteLine("체력이 떨어집니다");
//            Hp -= 50;
//            Console.WriteLine();
//        }
//    }

//    public void update()
//    {
//        while (true)
//        {

//            State();
//            Console.WriteLine("1. 걷다");
//            Console.WriteLine("2. 먹다");
//            Console.WriteLine("3. 잔다");
//            Console.WriteLine("4. 공부한다");
//            Console.WriteLine("5. 종료");

//            string Str_num = Console.ReadLine();

//            int num = int.Parse(Str_num);

//            if (num == 5)
//            {
//                return;
//            }


//            Interface = (Interface)num;

//            switch (Interface)
//            {
//                case Interface.walk:
//                    {
//                        Walk();
//                    }
//                    break;
//                case Interface.eat:
//                    {
//                        eat();
//                    }
//                    break;
//                case Interface.sleep:
//                    {
//                        Sleep();
//                    }
//                    break;
//                case Interface.study:
//                    {
//                        Study();
//                    }
//                    break;
//                default:
//                    break;
//            }
//        }
//    }

//}

//Movie_Interface movie_Interface = new Movie_Interface();
//movie_Interface.Update();


//class Base_Movie
//{
//    protected string Title = "";
//    protected string Genre = "";
//    protected int Score = 0;
//    protected int RunningTime = 100;

//    virtual public void Start()
//    {

//    }

//    virtual public void State()
//    {

//    }
//}

//class Move_01 : Base_Movie
//{
//    override public void Start()
//    {
//        Title = "Move_01";
//        Genre = "액션";
//        Score = 59;
//        RunningTime = 130;
//    }

//    override public void State()
//    {
//        Console.WriteLine("제목 : " + Title);
//        Console.WriteLine("장르 : " + Genre);
//        Console.WriteLine("점수 : " + Score);
//        Console.WriteLine("러닝타임 : " + RunningTime);
//    }

//}

//class Move_02 : Base_Movie
//{
//    override public void Start()
//    {
//        Title = "Move_02";
//        Genre = "스릴러";
//        Score = 80;
//        RunningTime = 150;
//    }

//    override public void State()
//    {
//        Console.WriteLine("제목 : " + Title);
//        Console.WriteLine("장르 : " + Genre);
//        Console.WriteLine("점수 : " + Score);
//        Console.WriteLine("러닝타임 : " + RunningTime);
//    }

//}


//class Move_03 : Base_Movie
//{
//    override public void Start()
//    {
//        Title = "Move_03";
//        Genre = "드라마";
//        Score = 60;
//        RunningTime = 50;
//    }

//    override public void State()
//    {
//        Console.WriteLine("제목 : " + Title);
//        Console.WriteLine("장르 : " + Genre);
//        Console.WriteLine("점수 : " + Score);
//        Console.WriteLine("러닝타임 : " + RunningTime);
//    }
//}


//class Movie_Interface
//{
//    private Base_Movie[] Arr = new Base_Movie[3];


//    public Movie_Interface()
//    {      
//        Arr[0] = new Move_01();
//        Arr[1] = new Move_02();
//        Arr[2] = new Move_03();
//    }


//    public void Update()
//    {
//        while (true)
//        {
//            Console.WriteLine("보고 싶은 영화를 골라주세요");

//            Console.WriteLine();

//            Console.WriteLine("0 : Move_01");
//            Console.WriteLine("1 : Move_02");
//            Console.WriteLine("2 : Move_03");
//            Console.WriteLine("3 : 종료");

//            string num = Console.ReadLine();

//            int Num = int.Parse(num);


//            switch (Num)
//            {
//                case 0:
//                    {
//                        Arr[0].Start();
//                        Arr[0].State();
//                        Console.WriteLine();
//                    }
//                    break;
//                case 1:
//                    {
//                        Arr[1].Start();
//                        Arr[1].State();
//                        Console.WriteLine();
//                    }
//                    break;
//                case 2:
//                    {
//                        Arr[2].Start();
//                        Arr[2].State();
//                        Console.WriteLine();
//                    }
//                    break;
//                case 3:
//                    {
//                        return;
//                    }

//                default:
//                    break;
//            }
//        }
//    }
//}

//Interface face = new Interface();

//face.Update();


//class Rect
//{ 
//    protected int x= 0; 
//    protected int y =0;
//    protected int extent;


//    virtual public void Set()
//    {
//        Console.Write("x : ");

//        string StrNum = Console.ReadLine();

//        int Num = int.Parse(StrNum);

//        x = Num;

//        Console.Write("y : ");

//        string StrNum_ = Console.ReadLine();

//        int Num_ = int.Parse(StrNum_);

//        y = Num_;
//    }


//   virtual public void Area()
//   {
//        extent = x * y;

//        Console.WriteLine("넓이 : " + extent);

//   }

//}



//class rectangle : Rect
//{ 
//    public rectangle()
//    {
//        x = 5;
//        y = 10;
//    }

//    public override void Area()
//    {
//        base.Area();
//    }


//}

//class rhombus : Rect
//{
//    public rhombus()
//    {
//        x = 10;
//        y = 10;
//    }


//    public override void Area()
//    {
//        extent = (x * y) / 2;


//        Console.WriteLine("넓이 : " + extent);
//    }


//}

//class square : Rect
//{
//    public square()
//    {
//        x = 8;
//        y = 8;
//    }


//    override public void Set()
//    {
//        Console.WriteLine("x : ");
//        Console.WriteLine("y : ");
//        string StrNum = Console.ReadLine();

//        int Num = int.Parse(StrNum);

//        x = Num;
//        y = Num;

//    }


//}

//class Interface
//{
//    private Rect[] Arr = new Rect[3];


//    public Interface()
//    {
//        Arr[0] = new rectangle();
//        Arr[1] = new rhombus();
//        Arr[2] = new square();
//    }

//     public void Update()
//     {
//         while (true)
//         {
//             Console.WriteLine("사각형을 골라주세요");
//             Console.WriteLine();
//             Console.WriteLine("0 : 직사각형");
//             Console.WriteLine("1 : 마름모");
//             Console.WriteLine("2 : 정사각형");
//             Console.WriteLine("3 : 종료");

//             string num = Console.ReadLine();

//             int Num = int.Parse(num);

//             switch (Num)
//             {
//                 case 0:
//                     {
//                        Arr[0].Set();
//                        Arr[0].Area();
//                         Console.WriteLine();
//                     }
//                     break;
//                 case 1:
//                     {
//                        Arr[1].Set();
//                        Arr[1].Area();
//                        Console.WriteLine();
//                     }
//                     break;
//                 case 2:
//                     {
//                        Arr[2].Set();
//                        Arr[2].Area();
//                        Console.WriteLine();
//                     }
//                     break;
//                 case 3:
//                     {
//                         return;
//                     }
//                 default:
//                     break;
//             }
//         }
//     }

//}

//class Bicycle
//{

//    public string Color { get; set; }
//    public int Age { get; set; }
//    public string Model { get; set; }
//    public double Speed { get; set; }


//    public Bicycle(string color, string brand, string model)
//    {
//        Color = color;
//        Model = model;
//        Speed = 100;
//    }


//    public void Speed_Up(int distance)
//    {
//        Speed += distance;
//    }

//    public void Speed_Down(int distance)
//    {
//        Speed -= distance;
//    }

//}



//class Program
//{
//    static void Main(string[] args)
//    {
//        new Program().Test();
//    }

//    // 델리게이트 정의
//    delegate int MyDelegate(string s);

//    void Test()
//    {
//        //델리게이트 객체 생성
//        MyDelegate m = new MyDelegate(StringToInt);

//        m("12");
//        //델리게이트 객체를 메서드로 전달
//        Run(m);
//    }

//    // 델리게이트 대상이 되는 어떤 메서드
//    int StringToInt(string s)
//    {
//        return int.Parse(s);
//    }

//    // 델리게이트를 전달 받는 메서드
//    void Run(MyDelegate m)
//    {
//        // 델리게이트로부터 메서드 실행
//        int i = m("123");

//        Console.WriteLine(i);
//    }
//}
// 문제 1


//MyFriendDetailInfo myFriendDetailInfo = new MyFriendDetailInfo();
//myFriendDetailInfo.ShowMyFriendInfo(); 

//class MyFriendInfo
//{
//    protected string Name = "이순신"; 
//    protected int Age = 100;

//}

//class MyFriendDetailInfo : MyFriendInfo
//{
//    private string Address = "성균관";
//    private string Phone_Number = "010-1000-8888";

//    public void ShowMyFriendInfo()
//    {
//        Console.WriteLine(Name);
//        Console.WriteLine(Age);
//        Console.WriteLine(Address);
//        Console.WriteLine(Phone_Number);
//    }
//}

// 문제 2 

//ColorTv colorTv = new ColorTv();

//colorTv.printProperty();

//class TV
//{
//    protected int inch = 32;
//    protected int Pixel = 1024;
//}

//class ColorTv : TV
//{
//    public void printProperty()
//    {
//        Console.WriteLine(inch + "인치" + Pixel + "컬러출력");
//    }
//}

// 문제 3 


//IPTV iPTV = new IPTV();
//iPTV.printProperty();

//class TV
//{
//    protected int inch = 32;
//    protected int Pixel = 1024;
//}

//class ColorTv : TV
//{
//    public virtual void printProperty()
//    {
//        Console.WriteLine(inch + "인치" + Pixel + "컬러출력");
//    }
//}

//class IPTV : ColorTv
//{
//    private string Address = "192.1.1.2";

//    public override void printProperty()
//    {
//        Pixel = 2048;

//        Console.WriteLine("나의 IPTV는"+ Address + "주소의" + inch + "인치" + Pixel + "컬러출력");
//    }

//}


// 문제 4 

//Convert convert = new Convert();

//Won2Dollor won2Dollor = new Won2Dollor();
//won2Dollor.Run();

//class Converter
//{
//    protected float Dollor = 0;

//    public Converter()
//    {
//        Console.WriteLine("원을 달러로 바꿉니다");
//        Console.WriteLine("원을 입력하세요");

//        System.String Str_Won = Console.ReadLine();

//        Dollor = float.Parse(Str_Won)/1200;
//    }
//}
//class Won2Dollor : Converter
//{
//    public void Run()
//    {

//        Console.WriteLine("변환결과 :" + Dollor + "달러입니다");

//        Console.WriteLine();
//    }
//}

// 문제 5 

//Convert convert = new Convert();

//Km2Mile km2Mile = new Km2Mile();
//km2Mile.Run();

//class Converter
//{
//    protected float Mile = 0;

//    public Converter()
//    {
//        Console.WriteLine("Km를 Mile로 바꿉니다");
//        Console.WriteLine("km를 입력해주세요");

//        System.String Str_Km = Console.ReadLine();

//        Mile = float.Parse(Str_Km) * (float)1.6;


//    }
//}
//class Km2Mile : Converter
//{
//    public void Run()
//    {

//        Console.WriteLine("변환결과 :" + Mile + "입니다");

//        Console.WriteLine();
//    }
//}

// 문제 6

//ColorPoint colorPoint = new ColorPoint();
//colorPoint.update();

//Console.WriteLine(colorPoint);


//class Point
//{
//    protected string Color = "RED";
//    protected double Pos_X = 10;
//    protected double Pos_Y = 10;

//}

//class ColorPoint : Point
//{
//    public void update()
//    {
//        Console.WriteLine(Color + "색의({0},{1})의 점입니다", Pos_X, Pos_Y);
//    }

//    public override System.String ToString()
//    {
//        return "이름변경";
//    }
//}

// 문제 1

//class CalCulator
//{
//    private int Value = 0;

//    public void Plus(int A ,int B)
//    {
//        Value = A + B;
//    }

//    public void Plus(int A, int B, int C)
//    {
//        Value = A+B+C;
//    }
//}

// 문제 2 

//People people = new Student();
//people.Start();


//class People
//{
//    protected int Age = 0;
//    protected string name = "";
//    protected int Height = 0;


//    public virtual void Start()
//    {
//        Age = 0;
//        name = "사람";
//        Height = 100;

//        Console.WriteLine(Age);
//        Console.WriteLine(name);
//        Console.WriteLine(Height);
//    }
//}

//class Student : People
//{
//    public override void Start()
//    {
//        Age = 100;
//        name = "학생";
//        Height = 1000;

//        Console.WriteLine(Age);
//        Console.WriteLine(name);
//        Console.WriteLine(Height);
//    }
//}

//Worker worker = new Worker();
//worker.Work();

//Worker programmer = new Programmer();
//programmer.Work();

//Worker designer = new Designer();
//designer.Work();

//Worker cleaner = new Cleaner();
//cleaner.Work();

//class Worker
//{
//    public virtual void Work()
//    {
//        Console.WriteLine("일하는 사람");
//    }
//}

//class Programmer : Worker
//{
//    public override void Work()
//    {
//        Console.WriteLine("프로그래머");
//    }
//}

//class Designer : Worker
//{
//    public override void Work()
//    {
//        Console.WriteLine("디자이너");
//    }
//}

//class Cleaner : Worker
//{
//    public override void Work()
//    {
//        Console.WriteLine("청소부");
//    }
//}

// 문제 1 

//class Triangle
//{
//    private int area = 0;
//    public void Finding_area(int base_, int height)
//    {
//        area = base_ * height/2;

//        Console.WriteLine(area);
//    }
//}
// 문제 2 

//CalculctorEx calculctor =new CalculctorEx();
//calculctor.Calculate();

//class CalculctorEx
//{
//    private int sign = 0;
//    private int Check = 0;


//    public void Start()
//    {
//        Console.WriteLine("부호를 고르세요");

//        Console.WriteLine("1 : + , 2 : - , 3 : *  , 4 : / ,5 : 종료");

//        string Str_Num = Console.ReadLine();

//        try
//        {
//            sign = int.Parse(Str_Num);
//        }
//        catch
//        {
//            Console.WriteLine("잘못 입력하였습니다");
//        }
//    }


//    public void Calculate()
//    {
//        while (true)
//        {
//            Start();

//            switch (sign)
//            {
//                case 1:
//                    {
//                        Console.WriteLine("[]+[]");

//                        string Str_First_Num = Console.ReadLine();

//                        int First_Num = int.Parse(Str_First_Num);

//                        string Str_Second_Num = Console.ReadLine();

//                        int Second_Num = int.Parse(Str_Second_Num);

//                        Console.WriteLine(First_Num + Second_Num);

//                        Check++;
//                    }
//                    break;
//                case 2:
//                    {
//                        Console.WriteLine("[]-[]");

//                        string Str_First_Num = Console.ReadLine();

//                        int First_Num = int.Parse(Str_First_Num);

//                        string Str_Second_Num = Console.ReadLine();

//                        int Second_Num = int.Parse(Str_Second_Num);

//                        Console.WriteLine(First_Num - Second_Num);

//                        Check++;
//                    }
//                    break;
//                case 3:
//                    {
//                        Console.WriteLine("[] * []");

//                        string Str_First_Num = Console.ReadLine();

//                        int First_Num = int.Parse(Str_First_Num);

//                        string Str_Second_Num = Console.ReadLine();

//                        int Second_Num = int.Parse(Str_Second_Num);

//                        Console.WriteLine(First_Num * Second_Num);

//                        Check++;
//                    }
//                    break;
//                case 4:
//                    {
//                        Console.WriteLine("[] / []");

//                        string Str_First_Num = Console.ReadLine();

//                        int First_Num = int.Parse(Str_First_Num);

//                        string Str_Second_Num = Console.ReadLine();

//                        int Second_Num = int.Parse(Str_Second_Num);

//                        Console.WriteLine(First_Num / Second_Num);
//                        Check++;
//                    }
//                    break;
//                case 5:
//                    {
//                        Console.WriteLine("{0}번 계산하였습니다", Check);
//                        return;
//                    }                  
//                default:
//                    break;
//            }
//        }
//    }
//}

// 문제 3 


//Store store = new Store();
//store.Deal();

//class Store
//{
//    private int SellerCount = 50;
//    private int SellerPrice = 1000;
//    private int Sellerbalance = 0;

//    private int BuyerCount = 0;
//    private int Buyerbalance = 10000;


//    public void Start()
//    {
//        Console.WriteLine("사과의 양을 써주세요");

//        string Str_Num = Console.ReadLine();

//        SellerCount = int.Parse(Str_Num);

//        Console.WriteLine("가격을 써주세요");

//        string Str_Price = Console.ReadLine();

//        SellerPrice = int.Parse(Str_Price);

//    }




//    public void Deal()
//    {
//        Console.WriteLine("구매할 사과의 양을 써주세요");

//        string Str_Num = Console.ReadLine();

//        int num = int.Parse(Str_Num);

//        if(SellerCount < num)
//        {
//            Console.WriteLine("사과수가 부족합니다");
//        }
//        else if(Buyerbalance < num* SellerPrice)
//        {
//            Console.WriteLine("잔액이 부족합니다");
//        }

//        else
//        {
//            Console.WriteLine("구매행위가 일어나기 전의 상태");
//            Console.WriteLine("[판매자] 남은 사과 개수 :" + SellerCount);
//            Console.WriteLine("[판매자] 판매수익 :" + 0);
//            Console.WriteLine("[구매자] 현재잔액 :" + Buyerbalance);
//            Console.WriteLine("[구매자] 사과갯수 :" + BuyerCount);


//            SellerCount -= num;
//            Sellerbalance += num * SellerPrice;
//            BuyerCount += num;
//            Buyerbalance -= num * SellerPrice;


//            Console.WriteLine("구매행위가 일어난 후의 상태");
//            Console.WriteLine("[판매자] 남은 사과 개수 :" + SellerCount);
//            Console.WriteLine("[판매자] 판매수익 :" + num * SellerPrice);
//            Console.WriteLine("[구매자] 현재잔액 :" + Buyerbalance);
//            Console.WriteLine("[구매자] 사과갯수 :" + BuyerCount);
//        }
//    }

//}

// 문제 4 

//Person person = new Person();




//class Person
//{
//    public string name { get; set; } = "";
//    public string address { get; set; } = "";
//    public string Number { get; set; } = "";

//    public Person()
//    {
//        name = "사람";
//        address = "서울";
//        Number = "010000";
//    }


//}

//class Customer : Person
//{
//    public string id { get; set; } = "";
//    public int mileage { get; set; } = 0;

//    public Customer()
//    {     
//       id = "code";
//       mileage = 100;
//    }
//}


// 문제 5

//HomeAppliance homeAppliance = new Television();

//homeAppliance.GetPrice();


//HomeAppliance homeAppliance_02 = new Refrigerator();

//homeAppliance_02.GetPrice();

//class HomeAppliance
//{
//    protected double Price = 1000;

//    public virtual double GetPrice()
//    {
//        Console.WriteLine(Price);
//        return 0;
//    }
//}

//class Television : HomeAppliance
//{
//    public override double GetPrice()
//    {
//        Console.WriteLine(Price * 0.9);

//        return Price/0.9;
//    }
//}

//class Refrigerator : HomeAppliance
//{
//    public override double GetPrice()
//    {
//        Console.WriteLine(Price * 0.95);

//        return Price / 0.95;
//    }
//}

// 문제 6

GameCharacter[] Arr = new GameCharacter[5];

Arr[0] = new Hobbit();

Arr[1] = new Sorcerer();

Arr[2] = new GameCharacter();

while (true)
{
    Arr[0].Draw();
    Arr[1].Draw();
    Arr[2].Draw();
}


class GameCharacter
{
    public virtual void Draw()
    {
        Console.WriteLine("그립니다");
    }

}
class Hobbit : GameCharacter
{
    public override void Draw()
    {
        Console.WriteLine("호빗을 그립니다");
    }
}

class Sorcerer : GameCharacter
{
    public override void Draw()
    {
        Console.WriteLine("주술사를 그립니다");
    }
}
