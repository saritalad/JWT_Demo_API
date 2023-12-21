describe('Hello world', () => {

    let expected = "";
  
    beforeEach(() => {
      expected = "Hello World";
    });
  
    afterEach(() => {
      expected = "";
    });
  
    it('says hello', () => {
      expect(helloWorld())
          .toEqual(expected);
    });
  });