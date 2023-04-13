using System;

class Program
{
    static void Main(string[] args)
    {
        // Hỏi người dùng về kích thước ma trận
        Console.Write("Nhập số hàng của ma trận: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Nhập số cột của ma trận: ");
        int cols = int.Parse(Console.ReadLine());

        // Tạo ma trận từ giá trị nhập liệu của người dùng
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhập giá trị cho phần tử [{i}, {j}]: ");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        // Tìm phần tử lớn nhất và tọa độ tương ứng
        double maxVal = matrix[0, 0];
        int maxRow = 0, maxCol = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > maxVal)
                {
                    maxVal = matrix[i, j];
                    maxRow = i;
                    maxCol = j;
                }
            }
        }

        // Hiển thị kết quả
        Console.WriteLine($"Phần tử lớn nhất của ma trận là {maxVal} ở tọa độ [{maxRow}, {maxCol}].");
    }
}

