<h2>A biblioteca Refit</h2><p>O Refit é uma biblioteca que permite representar uma REST API através de uma interface.</p>



<p>Confuso? Creio que seja melhor explicar com um exemplo concreto!</p>



<p>Imagine a seguinte situação:</p>



<ul><li>Uma API <em>Orders </em>precisa processar um pagamento de um pedido, e para isso ele delegará a transação a outra API <em>Payments</em>;</li><li>A comunicação é síncrona, e através de uma chamada HTTP;</li><li>Logo, será necessário: implementar um método, criar o objeto <em>HttpClient</em>, obter a URL, realizar a requisição, e finalmente deserializar o objeto recebido.</li></ul>



<p>As mesmas operações se repetiriam para cada chamada dessa comunicação entre os serviços. Um pouco repetitivo, certo? Por mais que esses comportamentos sejam extraídos para um método à parte, ainda assim se nota redundância de código.</p>



<p>O <em>Refit </em>permite que esse processo todo seja simplificado através da definição de uma interface, que poderá ser chamada das classes clientes. Isso resulta em uma redução de código incrível.</p>

