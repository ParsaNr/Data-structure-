using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Node<T>
    {
        public Node<T> next { get; set; }
        public string key { get; set; }
        public T value { get; set; }
    }
    class HashTable<T>
    {
        private readonly Node<T>[] bucket;
        public HashTable(int size)
        {
            bucket = new Node<T>[size];
        }
        public T Get(string key)
        {
            ValidateKey(key);

            var (_, node) = GetNodeByKey(key);

            if (node == null)
                throw new ArgumentOutOfRangeException("No Argument Found");

            return node.value;
        }
        public int GetBucketByKey(string key)
        {
            return key[0] % bucket.Length;
        }
        public void add(string key, T item)
        {
            var valeNode = new Node<T> { key = key, value = item, next = null };
            int position = GetBucketByKey(key);
            Node<T> link = bucket[position];

            if (bucket[position] == null)
                bucket[position] = valeNode;
            else
            {
                while (link.next != null)
                    link = link.next;
                link.next = valeNode;
            }
        }
        public bool remove(string key)
        {
            ValidateKey(key);
            int position = GetBucketByKey(key);
            var (previous, current) = GetNodeByKey(key);

            if (current == null)
                return false;
            if (previous == null)
            {
                bucket[position] = null;
                return true;
            }

            previous.next = current.next;
            return true;
        }
        public bool ContainsKey(string key)
        {
            ValidateKey(key);

            var (_, node) = GetNodeByKey(key);
            return node != null;
        }
        protected void ValidateKey(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                return;
        }
        protected (Node<T> previous, Node<T> Current) GetNodeByKey(string key)
        {
            int position = GetBucketByKey(key);
            Node<T> link = bucket[position];
            Node<T> previous = null;

            while (link != null)
            {
                if (link.key == key)
                    return (previous, link);

                previous = link;
                link = link.next;
            }
            return (null, null);
        }
    }
}
