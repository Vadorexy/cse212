/// <summary>
/// A basic implementation of a Queue
/// </summary>
public class PersonQueue
{
    private readonly List<Person> _list = new List<Person>();

    public void Enqueue(Person person)
    {
        _list.Add(person);                  // Add to End (back)
    }

    public Person Dequeue()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("Queue is empty");

        Person frontPerson = _list[0];
        _list.RemoveAt(0);                  // Remove from Front
        return frontPerson;
    }

    public bool IsEmpty()
    {
        return _list.Count == 0;
    }

    public int Length => _list.Count;

    public override string ToString()
    {
        return $"[{string.Join(", ", _list.Select(p => $"{p.Name} ({p.Turns})"))}]";
    }
}