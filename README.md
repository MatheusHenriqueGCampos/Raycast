# Raycast
Projeto de teste de Raycast pela dupla Matheus e Igor Michelini

## Assets usados
https://assetstore.unity.com/packages/3d/characters/stylized-simple-hands-221297

## Cena
Na cena foram criados 6 GameObjects: Um plano para ser o chão, um cilindro, 2 cubos, uma esfera e o Jogador
Há também movimentação e pontuação para o jogador.

Cilindro: Quando acertado, é adicionado um component RigidBody, muda sua cor para azul e fornece 10 pontos <br> 
Cubo 1: Quando acertado, muda sua cor para preto e fornece 15 pontos <br>
Cubo 2: Quando acertado, ele é destruído e fornece 30 pontos. <br>
Esfera: Quando acertado, gera ema cópia na esquerda da anterior, sua cor é alterada para verde e fornece 25 pontos. <br>

## Como funciona
<ol> <li>Foi criada uma layer chamada Hittable. onde se encontram todos os GameObjects acertáveis pelo Raycast</li>
<li>Também uma Interface chamada IHittable, na qual todos os GameObjects acertáveis herdarão </li>
<li>Ao clicar o botão esquerdo do mouse, é atirado um raio na posição atual do mouse na tela. Após isso, é criada uma variável local recebendo o componente IHittable do GameObject acertado </li>
<li>Após isso, é checado se a layer do GameObject é a layer acertável e se a variável local não é nula. Caso ambos forem verdadeiros, é chamada a função OnHit da Interface </li></ol>

Movimentação: Utilizado o Input.GetAxis, tanto na horizontal quanto na vertical e adiciona velocidade ao RigidBody multiplicada pelo valor do input <br>
Pontuação: Uma variável estática inteira currentScore, que é acessada nos scripts dos inimigos ao serem atingidos
