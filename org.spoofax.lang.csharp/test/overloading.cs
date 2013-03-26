namespace Parameters {
  class A {
    void func() { }
    int func(int a) { return a; }
    string func(int a, string b) { return b;}
    
    void test() {
      func();
      int a = func(1);
      string b = func(2, "hello");
    }
  }
}