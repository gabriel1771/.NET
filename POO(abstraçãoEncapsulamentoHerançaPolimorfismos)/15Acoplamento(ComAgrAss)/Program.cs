

using _15Acoplamento_ComAgrAss_;

ComportamentoAndar andar = new();
ComportamentoNadar nadar = new();

Homem homem = new(andar);
//homem.Locomocao();
homem._ComportamentoAndar.Andar();


Macaco macaco  = new(andar);
//Macaco.Locomocao();
macaco._ComportamentoAndar.Andar();


Sardinha sardinha = new(nadar);
sardinha.Locomocao();
sardinha._ComportamentoNadar.Nadar();



Console.ReadKey();