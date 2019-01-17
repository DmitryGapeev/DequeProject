using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

  class Deque<T>
  {
    private LinkedList<T> _items;
    public Deque()
    {
      _items = new LinkedList<T>();
    }

    public void AddFront(T item)
    {
      _items.AddFirst(new LinkedListNode<T>(item));
    }

    public void AddTail(T item)
    {
      _items.AddLast(item);
    }

    public T RemoveFront()
    {
      if(_items.Count == 0)
        return default(T);

      T result = _items.First.Value;
      _items.RemoveFirst();
      return result;
    }

    public T RemoveTail()
    {
      if(_items.Count == 0)
        return default(T);

      T result = _items.Last.Value;
      _items.RemoveLast();
      return result;
    }

    public int Size()
    {
      return _items.Count;
    }
  }

}