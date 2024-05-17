namespace DotNetMyths.Common;

public class ForBoxing
{
    public static Type GetByTypeof()
    {
        Type type = typeof(StructWithOverlapping);
        return type;
    }

    public static Type GetStructByGetType()
    {
        Type type = new SomeStruct().GetType();
        return type;
    }
    
    public static Type GetClassByGetType()
    {
        Type type = new SomeClass().GetType();
        return type;
    }

    public static Type GetTypeGeneric<TType>(TType value)
    {
        Type type = value.GetType();
        return type;
    }
}