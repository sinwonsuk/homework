// See https://aka.ms/new-console-template for more information
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
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

