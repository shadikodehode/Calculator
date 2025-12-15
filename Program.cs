// simple calculator with if statements


            Console.WriteLine("Start by entering a number, then operator (+, -, *, /) and finally second number"); 
            //shows the user instructions on what to do next
            double num1 = Convert.ToDouble(Console.ReadLine());
            //creates a double variable that can use decimals, ReadLine to input numbers without defining them first                                                     

            Console.WriteLine("Enter operator");
            string? op = Console.ReadLine(); //unknown null error, "?" after string was the solution

            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());          

            if (op == "+")            
            {
                double add = num1 + num2;
                Console.WriteLine("Result:" + num1 + "+" + num2 + "="+ add);        
            }
            if (op == "-")            
            {
                double sub = num1 - num2;
                Console.WriteLine("Result:" + num1 + "-" + num2 + "="+ sub);         
            }
            if (op == "*")            
            {
                double mul = num1 * num2; 
                Console.WriteLine("Result:" + num1 + "-" + num2 + "="+ mul);    
            }               
            if (op == "/")
            {
                 if (num2 == 0)
                {
                    Console.WriteLine("Error, cannot divide by 0");
                }else
                {
                    double div = num1 / num2;
                    Console.WriteLine("Result:" + num1 + "-" + num2 + "="+ div);
                }
            }
            
                   
            

            
            


            
            
  