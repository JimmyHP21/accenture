<script setup>
import SupplierItem from './SupplierItem.vue';
</script>

<script>
  export default {
    name: 'Welcome',
    props: {
        list: { type: Array }
    },
    created() { },
    methods: {}
  }
</script>

<template>
  <SupplierItem v-for="item in list" v-if="list.length > 0">
    <template #cnpj>
      {{item.cnpjSupplier}}
    </template>
    <template #stateRegi>
      {{item.stateRegistration}}
    </template>

    <template #ramo>{{item.business}}</template>
  </SupplierItem>
</template>
