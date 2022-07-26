import java.util.Scanner;

public class SwitchCalculator {
    public static void main(String[] args) {
        int num1, num2, result;
        char operator;
        Scanner scan = new Scanner(System.in);
        System.out.println("Enter first number: ");
        num1 = scan.nextInt();
        System.out.println("Enter second number: ");
        num2 = scan.nextInt();
        System.out.println("Enter the operation with numbers: 1 - +, 2 - -, 3 - *, 4 - /");
        operator = scan.next().charAt(0);
        switch (operator)
        {
            case '+':
                result = num1 + num2;
                System.out.println("Sum = " + result);
                break;
            case '-':
                result = num1 - num2;
                System.out.println("Difference = " + result);
                break;
            case '*':
                result = num1 * num2;
                System.out.println("Multiplication = " + result);
                break;
            case '/':
                result = num1 / num2;
                System.out.println("Division = " + result);
                break;
            default:
                System.out.println("Error operation");
                break;
        }
        int arr[][] = {{12,34,23},{56,324,89},{11,87,49}};
        int sum = 0;
        for(int i = 0; i < arr.length; i++)
        {
            for(int j = 0; j < arr.length; j++)
            {
                sum += arr[i][j];
            }
        }
        System.out.println(sum);
    }
}
