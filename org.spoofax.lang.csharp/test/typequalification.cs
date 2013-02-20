namespace TypeQualification {
	namespace First {
	  namespace TEST {}
		class A {
			int a;
		}
	}
	
	namespace Second {
	  class A { string a; }
	}
	
	using Second;
	
	class B {
		First.A a;
		Second.A aa;
		A aaa;
		
		int test() {
		  return a.a;
		}
		
		string test2() {
		  return aa.a;
		}
		
    string test3() {
      return aaa.a;
    }
	}
}