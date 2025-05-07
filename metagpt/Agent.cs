using System;

namespace MetaGPT {
    public class Agent {
        public string Name { get; set; }
        
        public void Speak(string message) {
            Console.WriteLine($"{Name}: {message}");
        }
    }
}