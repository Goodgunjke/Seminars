Console.Write("Введите число для проверки на палиндром : ");
            
            int number = int.Parse(Console.ReadLine());
            int remineder, sum = 0;
            int temp = number;
            while (number > 0)
            {
                 
                remineder = number % 10;
                
                sum = (sum * 10) + remineder;
               
                number = number / 10; 
            }
            if (temp == sum)
            {
                Console.WriteLine($"Число {temp} палиндром");
            }
            else
            {
                Console.WriteLine($"Число {temp} не палиндром");
            }
            