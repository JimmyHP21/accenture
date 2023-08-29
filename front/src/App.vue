<script setup>
import { RouterLink, RouterView } from 'vue-router';
</script>

<template>
  <div class="header">
    <div class="icons">
      <router-link to="/">
        <img src="./assets/Acc.png" />
      </router-link>
    </div>

    <div class="links">
      <router-link to="/">Home</router-link> |
      <router-link to="/new">Cadastro</router-link> 
    </div>
  </div>

  <RouterView />
</template>

<style lang="scss">
  .header {
    width: 100%;
    padding: 1rem 0;
    background-color: #fff;
    color: #000;
    font-weight: 600;
    font-size: 1rem;
    height: 2rem;
    display: flex;
    justify-content: space-between;
    align-items: center;
    
    img {
      width: 5rem;
      padding: 1rem;
    }

    a {
      text-decoration: none;
      color: #000;
      font-weight: 600;
      font-size: 1.2rem;
      padding: 1rem;
    }
  }
  .container {
    color: #888;
    display: flex;
    justify-content: center;
    padding: 1rem;
  }
</style>
