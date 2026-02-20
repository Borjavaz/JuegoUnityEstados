# Roll a Ball Estados

## Explicación

### Creo los objetos y le pongo nombre

<img width="224" height="195" alt="image" src="https://github.com/user-attachments/assets/51585236-82ca-427f-9987-5a544b146984" />

### Creo los materrials y se los asigno a cada objeto para darle color

<img width="360" height="137" alt="image" src="https://github.com/user-attachments/assets/e4754868-8e17-4e8c-a4d7-0c5f9a7ee194" />

---

> ***Añadir el Rigibody en Player***

<img width="647" height="327" alt="image" src="https://github.com/user-attachments/assets/be59cdd9-1a15-434b-ae59-146720de2ee9" />


### Mover la pelota

- ***Creo un script y lo llamo "PlayerController""***

<img width="614" height="533" alt="image" src="https://github.com/user-attachments/assets/274831b5-4a20-4dbb-ae86-b9939fb07f0e" />




- ***Cuando ya tengamos el script listo lo arrastramos hacia Player:***
  
<img width="413" height="77" alt="image" src="https://github.com/user-attachments/assets/020dc162-67b2-4704-ae7f-6d9f9dc69aa0" />

- ***Añadimos un tag al Player tambien:***

<img width="339" height="76" alt="image" src="https://github.com/user-attachments/assets/7d9b7544-fe96-4f7e-bdef-342688468c11" />

  
---

### Deteccion entre la bola y el cubo con debug

- ***Creo un nuevo script "CollisionDetector"***

#### Cuando comienza la colision

<img width="418" height="156" alt="image" src="https://github.com/user-attachments/assets/a44f2be8-a4f4-4f58-9625-2bbb4d29ba3c" />

#### Mientras esta colisionando

<img width="555" height="146" alt="image" src="https://github.com/user-attachments/assets/4cc0d48a-2a15-4127-970e-4d86a2027252" />


#### Cuando finaliza la colision

<img width="408" height="135" alt="image" src="https://github.com/user-attachments/assets/33fd4ff1-5464-4df4-b862-d395778be2b7" />



- ***Cuando tengamos el script completo lo arrastramos hasta el obteto Enemy***

---

### El cubo persige a la bola

- ***CCreo el script "EnemyFollower"***

Si no hay jugador no hace nada y calculo la distancia entre el Player y Enemy

<img width="702" height="258" alt="image" src="https://github.com/user-attachments/assets/6b2cab10-0f5e-464c-a9e3-7d7c0017534b" />

Manejo los estados Lejos y Cerca con sus respectivos Logs

<img width="607" height="434" alt="image" src="https://github.com/user-attachments/assets/1d470964-54e7-4436-a4bc-38fb7767e0c7" />



- ***Cuando el script este completo lo arrastramos hasta el objeto del Enemy***
- ***Ademas de colocar los 2 scripts tenemos que arrastrar el obteto Player para que el enemigo lo persiga

<img width="634" height="172" alt="image" src="https://github.com/user-attachments/assets/4ef271a5-7f7f-4afd-859e-670e2fd28019" />


 
