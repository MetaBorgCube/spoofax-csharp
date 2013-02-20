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
		A aa;
		
		int test() {
		  return a.a;
		}
		
		string test2() {
		  return aa.a;
		}
	}
}