public class EclipseDebuggingExample {
    public int add(int a, int b) {
        int result = a + b;
        return result;
    }

    public static void main(String[] args) {
    	// Basic
        EclipseDebuggingExample ede = new EclipseDebuggingExample();
        int a = 3;
        int b = 7;
        int result1 = ede.add(a, b);
        System.out.printf("%d + %d = %d", a, b, result1);
        
        // Conditional Breakpoint
        for (int i = 0; i < 10; i++) {
            System.out.println("i = " + i);
        }
        
        // Value change
        int c = 5;
        int d = 10;
        int result2 = c + d;
        System.out.println("Result: " + result2);
        
    }
}