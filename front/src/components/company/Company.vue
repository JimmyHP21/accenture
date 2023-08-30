<script setup>
import CompanyItem from './CompanyItem.vue';
</script>

<script>
  import axios from "axios";
  import router from "@/router";

  export default {
    name: 'Welcome',
    data() {
      return {
        data: []
      }
    },
    created() {
      this.getCompanys();
    },
    methods: {
      getCompanys() {
        axios
          .get("https://localhost:5001/api/Company")
          .then((res) => {
              this.data = res.data || [];
          })
          .catch((error) => {
            console.log(error);
          });
      },
      getData(id) {
        router.replace({ path: '/edit/' + id})
      },
      deleteCompany(id) {
        axios
          .delete("https://localhost:5001/api/Company/delete/" + id)
          .then((res) => {
              this.data = res.data || [];
          })
          .catch((error) => {
            console.log(error);
          });
      }
    }
  }
</script>

<template>
  <CompanyItem v-for="item in data" v-if="data.length > 0">
    <template #cnpj>
      {{item.cnpjCompany}}
    </template>
    <template #stateRegi>
      {{item.stateRegistration}}
    </template>

    <template #address>{{item.address}}</template>
    <template #number>{{item.number}}</template>
    <template #city>{{item.city}}</template>
    <template #state>{{item.state}}</template>
    
    <template #forn> {{ item.suppliers.length }} </template>

    <button class="edit" @click="getData(item.id)">E</button>
    <button class="delete" @click="deleteCompany(item.id)">D</button>
  </CompanyItem>
</template>

<style lang="scss">
  .edit {
    background-color: #0f0 !important;
    color: black;
    font-weight: 600;
  }

  .delete {
    background-color: #f00 !important;
    color: #fff;
    font-weight: 600;
  }
</style>
