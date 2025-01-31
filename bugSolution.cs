public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Initialize the property

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now it's safe to use MyProperty
    }

    // Or, if the property value should be set externally, you can use a constructor:
    public ExampleClass(int myPropertyValue)
    {
        MyProperty = myPropertyValue; 
    }
} 