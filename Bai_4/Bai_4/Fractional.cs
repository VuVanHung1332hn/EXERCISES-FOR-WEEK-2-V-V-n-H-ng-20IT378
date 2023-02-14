using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Fractional 
{

        //Instance fields
        long numerator;
        long denominator;

        //Static fields

        public static readonly Fractional ZERO;

        //Properties

        public long Numerator
        {
            get { return numerator; }
        }

        public long Denominator
        {
            get { return denominator; }
        }
        //Hàm khởi tạo

        //Tạo một phân số có dạng n/1

    public Fractional(long numerator)
        {
            this.numerator = numerator;
            denominator = 1;
        }

        //Tạo a/b trong điều kiện thấp nhất

    public Fractional(long numerator, long denominator)
        {
        //Điều kiện không thể có mẫu số bằng 0
        if (denominator == 0) throw new DivideByZeroException(
                "Lỗi không thể tính toán,Phân số không có mẫu số bằng không");
            //Nếu mẫu số âm, đảo dấu
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            //Tìm gcd của tử số và mẫu số
            long g = Math.Abs(gcd(numerator, denominator));

            //Chia nó ra
            this.numerator = numerator / g;
            this.denominator = denominator / g;
        }

    //Tạo một phân số từ một chuỗi
    //Chuỗi có thể là số nguyên; tức là không có mẫu số

   

    public Fractional(String s)
        {
            //Tính toán dựa trên ký tự phân số /
            char[] delim = { '/' };
            String[] numDen = s.Split(delim);

            
            if (numDen.Length < 1 || numDen.Length > 2)
                throw new FormatException(
                    "Số Không được nhập dưới dạng phân số");

            //Nếu có một mẫu số, giao cả hai
            if (numDen.Length != 1)
            {
                numerator = Int64.Parse(numDen[0]);
                denominator = Int64.Parse(numDen[1]);
                //Không xác định mẫu số; đặt thành 1
            }
             else
            {
                numerator = Int64.Parse(numDen[0]);
                denominator = 1;
            }

            // Đặt trong các điều khoản thấp nhất
            if (denominator == 0) throw new DivideByZeroException(
                    "Phân số có thể không có mẫu số bằng không");
            if (denominator < 0)
            {
                denominator = -denominator;
                numerator = -numerator;
            }
            long g = Math.Abs(gcd(numerator, denominator));
            numerator = numerator / g;
            denominator = denominator / g;
        }
        //Static constructor

        //Khởi tạo the static field

        static Fractional()
        {
            ZERO = new Fractional(0, 1);

        }

        //Methods


        private static long gcd(long a, long b)
        {
            if (b == 0) return a;
            return gcd(b, a % b);
        }

        //Tìm bội chung nhỏ nhất

        private static long lcm(long a, long b)
        {
            return a * b / gcd(a, b);
        }

      
        //Các phương pháp thực hiện phép tính phân số

        private Fractional Add(Fractional r)
        {
        //Cho hai phân số có mẫu số chung
        // bằng cách nhân chéo
        // Cộng các tử số
        // Rút gọn về số hạng nhỏ nhất bằng hàm tạo
        return new Fractional(numerator * r.denominator
                + r.numerator * denominator, denominator * denominator);
        }
        private Fractional Subtract(Fractional r)
        {
            
            return new Fractional(numerator * r.denominator
                - r.numerator * denominator,
                denominator * r.denominator);
        }

        private Fractional Multiply(Fractional r)
        {
            
            return new Fractional(numerator * r.numerator,
                denominator * r.denominator);

        }

        private Fractional Divide(Fractional r)
        {
            // Lật phân số thứ 2 và nhân
            return new Fractional(numerator * r.denominator, denominator * r.numerator);
        }


        public static Fractional Parse(String s)
        {
            return new Fractional(s);
        }


        public override string ToString()
        {
            if (denominator == 1) return numerator.ToString();
            else return numerator + "/" + denominator;
        }

         // Toán tử số học
        // Chỉ cần gọi Cộng, Trừ, Nhân, Chia

        public static Fractional operator +(Fractional s, Fractional r)
        {
            return r.Add(s);
        }

        public static Fractional operator -(Fractional s, Fractional r)
        {
            return r.Subtract(s);
        }
        public static Fractional operator *(Fractional s, Fractional r)
        {
            return r.Multiply(s);
        }

        public static Fractional operator /(Fractional s, Fractional r)
        {
            return r.Divide(s);
        }
    }



