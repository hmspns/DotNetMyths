namespace DotNetMyths.Common;

public class ByRefOrByValue
{
    public void ClassByValue(SomeClass cls)
    {
        
    }

    public void ClassByRef(ref SomeClass cls)
    {
        
    }

    public void StructByValue(SomeStruct str)
    {
        
    }

    public void StructByRef(ref SomeStruct str)
    {
        
    }
    
    
    
    

    public void CallClass()
    {
        SomeClass cls = new SomeClass();
        ClassByValue(cls);
        ClassByRef(ref cls);
    }
    
    
    
    
    

    public void CallStruct()
    {
        SomeStruct str = new SomeStruct();
        StructByValue(str);
        StructByRef(ref str);
    }
    
    
    
    
    
    
}

