using System.Text.RegularExpressions;

namespace tryCatchBlock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student =null;
            try
            {
                student = new student();
                student.StudentName = "Okoro234";
                
                
            }catch
            {

            }
            
        }
        static void square()
        {
            try
            {
                Console.WriteLine(" Enter  a Number");
                var number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The square of {number} is {number * number}");


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error Info {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Retry with another number");

            }
        }
        static void divide()
        {
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot Divide by zero. please try again");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Invalid operation, please try again");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Invalid operation. please try again");

            }catch (FormatException ex)
            {
                Console.WriteLine("Not a valid format. please try again");
            }catch (Exception ex)
            {
                Console.WriteLine("Error occurred! Please try again");
            }
                
        }
        static void invalidException()
        {
            try
            {

            }
            catch 
            {
                Console.WriteLine("Exception occur");
            }
        }
    }
    public class student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
    [Serializable ]
    class InvalidStudentNameException:Exception
    {
        public InvalidStudentNameException()
        {

        }
        public InvalidStudentNameException(string name)
            :base (string.Format ($"Invalid student Name:{name} "))
        {

        }
        public static  void  ValidateStudent(student std)
        {
            Regex rex = new Regex("^[a-zA-Z]+$");
            if (!rex.IsMatch (std.StudentName ))
                throw new InvalidStudentNameException(std.StudentName );
        }

    }
}
