class MyStack
{
    private Queue<int> q = new Queue<int>();

    public void Push(int x)
    {
        q.Enqueue(x);
    }

    public int Pop()
    {
        int count = q.Count;
        for (int i = 0; i < count - 1; i++)
        {
            Push(q.Dequeue());
        }
        return q.Dequeue();
    }

    public int Top()
    {
        return q.Last();
    }

    public bool Empty()
    {
        return q.Count == 0;
    }
}