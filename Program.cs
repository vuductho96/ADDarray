using System;

namespace AddArray
{
    class Program
    {
        static void Main(string[] args)
        {   int N= Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Nhap vao N phan tu");
            
            int [] songuyen  = new int[N];
             Console.WriteLine("Nhap vao index can chen vao mang:");
             int index=Convert.ToInt32(Console.ReadLine());
             if (index<1 || index>=songuyen.Length){
                Console.WriteLine("Khong thuc hien duoc");}
else {
 Console.WriteLine("Nhap vao so can chen:");
 int value = Convert.ToInt32(Console.ReadLine());
 for (int i=N-1;i>index;i--){
    songuyen[i]=songuyen[i-1];//dich chuyen phan tu sang ben trai


}songuyen[index]=value;////tang kich thuoc mang len 1 don vi
 Console.WriteLine("Mang sau khi chen la:");
                for (int i = 0; i < N; i++)
                {
                    Console.Write(songuyen[i] + " ");
                }
             }
            }
        }
    }

