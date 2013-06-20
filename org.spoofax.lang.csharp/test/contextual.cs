//using N.N.N;

namespace N {
  class C {
    C f;
    void m(C c) {}
  }
  
  class D {
    void m(C p) {
      p.m(p.f);
    }
  }

  class C2 {
    void m(int[] x) {
      foreach(int x in x)
        print(x+1);
     
      for(int i = 0; true; i = 1;)
        print(i+1);
    }
    void print(int x) {
      //System.Console.WriteLine(x);
    }
  }
} 