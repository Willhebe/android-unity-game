using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntegerVariable : ScriptableObject
{
    public int variable;
}

[CreateAssetMenu]
public class Velocity2D : ScriptableObject
{
    public FloatVariable xDirection;
    public FloatVariable yDirection;
}

[CreateAssetMenu]
public class FloatVariable : ScriptableObject
{
    public float Variable; 
}

[CreateAssetMenu]
public class StringVariable : ScriptableObject
{
    public string Variable;
}

[CreateAssetMenu]
public class IntelligentObject : ScriptableObject
{
    public IntegerVariable LevelOfIntelligence;
    public StringVariable ConsistsOf;
    public StringVariable Effects;
    public StringVariable AffectedBy;
    public Sprite Reprensentation;
    public IntegerVariable Health;
    
}

public abstract class RunTimeSet<T> : ScriptableObject
{
    public List<T> Items = new List<T>();
    public void Add(T t)
    {
        if (!Items.Contains(t)) Items.Add(t);
    }
    public void Remove (T t)
    {
        if (Items.Contains(t)) Items.Remove(t);
    }
}

public class SpriteList<StringVariable> : RunTimeSet<StringVariable>
{
    /*
    public void ShakeIfLow ()
    {
        if (Items.Count < 2)
        {
            // do something like send message elsewhere
            
        }
    }
    */
}



