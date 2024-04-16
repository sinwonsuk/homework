// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Text;

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