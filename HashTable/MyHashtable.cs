namespace DSA__VSCode.vscode.HashTable
{
    public class HashObject
    {
        public string Key {get; set; }
        public int Value {get; set; }
        public HashObject(string key, int value)
        {
            this.Value = value;
            this.Key = key;
        }
    }

    class HashTable
    {
        private class Nodes : List<HashObject>{};
        private int length;
        private Nodes[] data;

        public HashTable(int size)
        {
            this.length = size;
            this.data= new Nodes[size];
        }

        private int Hash(string key)
        {
            int hash = 0;
            for(int i = 0; i < key.Length; i++)
            {
                hash = (hash + (int)key[i] * i)% this.data.Length;
            }
            return hash;
        }

        public void Set(string key, int value)
        {
            int index = Hash(key);
            if(this.data[index] == null)
            {
                this.data[index] = new Nodes();
            }
            this.data[index].Add(new HashObject(key, value));
            
        }

        public int Get(string key)
        {
            int index = Hash(key);
            if(this.data[index] != null)
            {
                foreach(var node in this.data[index])
                {
                    if(node.Key == key) return node.Value;
                }
            }

            return -1;
        }

        public List<string> Keys()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < this.data.Length; i++)
            {
                if(this.data[i]!=null)
                {
                    for (int j = 0; j < this.data[i].Count(); j++)
                    {
                        result.Add(this.data[i][j].Key);
                    }
                   
                }
            
            }
            return result;
        }
    }
/*
HashTable hash = new HashTable(30);
hash.Set("Apples",100);
hash.Set("Grapes",200);
hash.Set("Mangoes",300);
hash.Set("mangoes",400);
hash.Set("mangoe",500);

Console.WriteLine(hash.Get("mangoes").ToString());

List<string> strs = hash.Keys();
foreach( string temp in strs)
    Console.WriteLine(temp);
    */

}