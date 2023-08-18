//PI & Abs


double piValue = Math.PI;
Console.WriteLine("Math.PI: " + piValue);
int absoluteValue = Math.Abs(-10);
Console.WriteLine("Math.Abs(-10): " + absoluteValue);

//Floor & Ceiling
double floorValue = Math.Floor(1.99);
Console.WriteLine("Math.Floor(1.99): " + floorValue);
double ceilingValue = Math.Ceiling(1.01);
Console.WriteLine("Math.Ceiling(1.01): " + ceilingValue);

//Round
double roundedValue = Math.Round(4.455, 2);
Console.WriteLine("Math.Round(4.456, 2): " + roundedValue);
double roundedValue2 = Math.Round(4.456, 1);
Console.WriteLine("Math.Round(4.456, 1): " + roundedValue2);


//Max & Min

int minValue = Math.Min(3, 5);
Console.WriteLine("Math.Min(3, 5): " + minValue);
int maxValue = Math.Max(5, 3);
Console.WriteLine("Math.Max(5, 3): " + maxValue);


//Pow & Sqrt
double powerValue = Math.Pow(2, 3);
Console.WriteLine("Math.Pow(2, 3): " + powerValue);
double squareRootValue = Math.Sqrt(16);
Console.WriteLine("Math.Sqrt(16): " + squareRootValue);


/*
 
Bạn đang lập trình một trò chơi máy tính. Người chơi thu thập quặng và bán chúng để nhận 
được đồng xu vàng. Quy tắc:
• Với 10 mảnh quặng đầu tiên, người chơi nhận được 10 đồng xu vàng cho mỗi mảnh.
• Với 5 mảnh quặng tiếp theo, người chơi nhận được 5 đồng xu vàng cho mỗi mảnh.
• Với 3 mảnh quặng tiếp theo, người chơi nhận được 2 đồng xu vàng cho mỗi mảnh.
• Với tất cả các mảnh quặng còn lại, người chơi nhận được 1 đồng xu vàng cho mỗi mảnh.
Ví dụ: 25 mảnh quặng => nhận được 10 * 10 + 5 * 5 + 3 * 2 + 7 * 1 = 138 đồng xu vàng.
11 mảnh quặng => nhận được 10 * 10 + 1 * 5 = 105 đồng xu vàng.
Hãy viết một chương trình để thực hiện tính toán số xu vàng nhận được với yêu cầu:
1. Yêu cầu người chơi nhập số mảnh quặng đã thu thập.
2. In ra số lượng đồng xu vàng mà người chơi nhận được cho quặng đó

 */


int giatri = 12;
int manhquang10 = Math.Min(giatri, 10);
giatri = giatri - manhquang10;
int manhquang5 = Math.Min(giatri, 5);
giatri = giatri - manhquang5;
int manhquang3 = Math.Min(giatri, 3);
giatri = giatri - manhquang3;

int total = giatri + manhquang10 * 10 + manhquang5 * 5 + manhquang3 * 2;

Console.WriteLine("\nGiá tri: " + giatri);
Console.WriteLine("total: " + total);
Console.WriteLine("manhquang10: " + manhquang10);
Console.WriteLine("manhquang5: " + manhquang5);
Console.WriteLine("manhquang3: " + manhquang3);