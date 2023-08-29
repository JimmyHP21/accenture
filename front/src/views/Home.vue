<script setup>
import Company from '../components/company/Company.vue';
import { ref } from 'vue'

defineProps({
  msg: String,
})

</script>

<template>
  
  <div class="table__content">
    <Company />
  </div>
</template>

<style lang="scss">
  .table__content {
    color: #888;
    padding: 1rem;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
</style>
