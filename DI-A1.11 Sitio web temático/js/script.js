// Datos simulados para los pokémons usados en la web
const POKEMONS = [
  { id:1, name:"Bulbasaur", category:"Semilla Pokémon", types:["grass","poison"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png" },
  { id:4, name:"Charmander", category:"Lagartija Pokémon", types:["fire"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png" },
  { id:7, name:"Squirtle", category:"Tortuga Pokémon", types:["water"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png" },
  { id:25, name:"Pikachu", category:"Ratón Pokémon", types:["electric"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/25.png" },
  { id:39, name:"Jigglypuff", category:"Globo Canción", types:["fairy","normal"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/39.png" },
  { id:150, name:"Mewtwo", category:"Pokémon Genético", types:["psychic"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/150.png" },
  { id:133, name:"Eevee", category:"Evolución Pokémon", types:["normal"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/133.png" },
  { id:94, name:"Gengar", category:"Sombra", types:["ghost","poison"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/94.png" },
  { id:65, name:"Alakazam", category:"Psiquico", types:["psychic"], generation:"I", img:"https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/65.png" }
];

// UTIL: determina qué página estamos (index, detalles, extras)
const PATH = location.pathname.split("/").pop() || "index.html";

document.addEventListener("DOMContentLoaded", ()=> {
  highlightActiveTab();
  if(PATH === "index.html" || PATH === ""){
    renderPokemons();
    setupSearchFilter();
  }
  if(PATH === "detalles.html"){
    renderDetail();
    setupDetailForms();
  }
  if(PATH === "extras.html"){
    renderGallery();
  }
});

// resaltar tab activo (cambia iconos mediante atributo aria-current en HTML)
function highlightActiveTab(){
  // el HTML trae aria-current en la pestaña activa; aquí solo se asegura que el link correcto esté marcado
  document.querySelectorAll(".tabs .tab-link").forEach(link=>{
    const tab = link.dataset.tab;
    if((PATH==="index.html" && tab==="inicio") || (PATH==="detalles.html" && tab==="detalles") || (PATH==="extras.html" && tab==="extras")){
      link.setAttribute("aria-current","page");
    } else {
      link.removeAttribute("aria-current");
    }
  });
}

// RENDER INDEX
function renderPokemons(){
  const container = document.getElementById("pokemon-list");
  if(!container) return;
  container.innerHTML = "";
  POKEMONS.forEach(p => {
    const article = document.createElement("article");
    article.className = "card";
    article.dataset.type = p.types.join(" ").toLowerCase();
    article.innerHTML = `
      <img src="${p.img}" alt="${p.name}" loading="lazy" />
      <h3>${p.name}</h3>
      <p class="category">${p.category}</p>
      <p class="meta">Tipo: ${p.types.join(", ")} · Gen: ${p.generation}</p>
      <a class="btn" href="detalles.html?id=${p.id}">Ver detalles</a>
    `;
    container.appendChild(article);
  });
}

// SEARCH + FILTER handlers
function setupSearchFilter(){
  const input = document.getElementById("search-input");
  const select = document.getElementById("type-filter");
  const list = document.getElementById("pokemon-list");

  function applyFilter(){
    const q = input.value.trim().toLowerCase();
    const type = select.value;
    Array.from(list.children).forEach(card=>{
      const name = card.querySelector("h3").textContent.toLowerCase();
      const types = card.dataset.type;
      const matchesQ = name.includes(q);
      const matchesType = (type==="all") ? true : types.includes(type);
      card.style.display = (matchesQ && matchesType) ? "" : "none";
    });
  }

  input.addEventListener("input", applyFilter);
  select.addEventListener("change", applyFilter);
}

// DETALLES PAGE
function renderDetail(){
  // leer id desde query
  const params = new URLSearchParams(location.search);
  const id = Number(params.get("id")) || POKEMONS[0].id;
  const pokemon = POKEMONS.find(p=>p.id===id) || POKEMONS[0];

  // rellenar
  const img = document.getElementById("detail-image");
  const name = document.getElementById("detail-name");
  const cat = document.getElementById("detail-category");
  const meta = document.getElementById("detail-meta");

  if(img) img.src = pokemon.img;
  if(img) img.alt = pokemon.name;
  if(name) name.textContent = `${pokemon.name} (#${pokemon.id})`;
  if(cat) cat.textContent = pokemon.category;
  if(meta) meta.textContent = `Tipo: ${pokemon.types.join(", ")} · Gen: ${pokemon.generation}`;

  // también podemos pre-llenar el nombre del entrenador con un placeholder divertido
  const trainerInput = document.getElementById("trainer-name");
  if(trainerInput) trainerInput.value = "Entrenador/a";
}

// Formularios simulados en detalles
function setupDetailForms(){
  const captureForm = document.getElementById("capture-form");
  const captureResp = document.getElementById("capture-response");
  if(captureForm){
    captureForm.addEventListener("submit", e=>{
      e.preventDefault();
      captureResp.textContent = "Intentando capturar…";
      setTimeout(()=> {
        const success = Math.random() > 0.4;
        captureResp.textContent = success ? "¡Éxito! Has capturado al Pokémon (simulado)." : "Oh no… el Pokémon escapó. Intenta otra vez.";
      }, 800);
    });
  }

  const commentForm = document.getElementById("comment-form");
  const commentResp = document.getElementById("comment-response");
  if(commentForm){
    commentForm.addEventListener("submit", e=>{
      e.preventDefault();
      commentResp.textContent = "Publicando comentario…";
      setTimeout(()=> {
        commentResp.textContent = "Comentario publicado (simulado). Gracias por tu aporte.";
      }, 600);
    });
  }

  const subscribeForm = document.getElementById("subscribe-form");
  const subscribeResp = document.getElementById("subscribe-response");
  if(subscribeForm){
    subscribeForm.addEventListener("submit", e=>{
      e.preventDefault();
      subscribeResp.textContent = "Procesando suscripción…";
      setTimeout(()=> {
        subscribeResp.textContent = "¡Listo! Estás suscrito (simulado). Revisa tu correo.";
      }, 700);
    });
  }
}

// EXTRAS: render gallery thumbnails
function renderGallery(){
  const grid = document.getElementById("gallery-grid");
  if(!grid) return;
  grid.innerHTML = "";
  POKEMONS.slice(0,8).forEach(p=>{
    const img = document.createElement("img");
    img.src = p.img;
    img.alt = p.name;
    grid.appendChild(img);
  });
}