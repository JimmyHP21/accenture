<script setup>
import SupplierItem from './SupplierItem.vue';
</script>

<script>
  import axios from "axios";

  export default {
    name: 'Welcome',
    props: {
        list: []
    },
    data() {
      return {
        data: []
      }
    },
    created() {
      this.getCompanys();
      console.log(this.list)
    },
    methods: {
      getCompanys() {
        axios
          .get("https://localhost:5001/api/Company")
          .then((res) => {
              this.data = res.data;
          })
          .catch((error) => {
                  console.log(error);
          });
      }
    }
  }
</script>

<template>
  <SupplierItem v-for="item in list" v-if="list.length > 0">
    <template #cnpj>
      {{item.CnpjSupplier}}
    </template>
    <template #stateRegi>
      {{item.StateRegistration}}
    </template>

    <template #ramo>{{item.Business}}</template>
  </SupplierItem>
</template>
