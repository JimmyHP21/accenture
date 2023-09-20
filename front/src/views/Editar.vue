<script setup>
import { ref, reactive } from 'vue';
import Supplier from '../components/supplier/Supplier.vue';

defineProps({
  msg: String
})

</script>

<script>
  import axios from "axios";
  import router from "@/router";

  export default {
    name: 'Register',

    data() {
      return {
        edit: {},
        form: {
          NameCompany: '',
          CnpjCompany: '',
          StateRegistration: '',
          Cep: '',
          Address: '',
          City: '',
          State: '',
          Number: '',
          PhoneCompany: '',
          suppliers: []
        }
      }
    },

    created() {
        axios
          .get("https://localhost:5001/api/Company/" + this.$route.params.id)
          .then((res) => {
              this.form = res.data;
          })
          .catch((error) => {
            console.log(error);
          });
    },

    methods: {
      onSubmit() {
        axios
          .put("https://localhost:5001/api/Company/update/" + this.$route.params.id, this.form)
          .then(() => {
            router.replace({ path: '/' })
          })
          .catch((error) => {
            console.log(error)
          })
      }
    },
  }
</script>


<template>
  <div class="card">

    <h2> Empresa</h2>

    <form class="register_form">
      <div class="row">
        <input v-model="form.nameCompany" placeholder="Nome da Companhia"  />
        <input v-model="form.cnpjCompany" placeholder="CNPJ da Companhia"  />
      </div>
      <div class="row">
        <input v-model="form.stateRegistration" placeholder="Registro de Estado"  />
      </div>
      <div class="row">
        <input v-model="form.address" placeholder="Endereço"  />
        <input type="number" v-model="form.number" placeholder="Numero"  />
      </div>
      <div class="row">
        <input v-model="form.city" placeholder="Cidade"  />
        <input v-model="form.cep" placeholder="00000-000" />
        <input v-model="form.state" placeholder="Estado"  />
      </div>
      <div class="row">
        <input v-model="form.phoneCompany" placeholder="Telefone"  />
      </div>
      
      
      
    </form>

    <h2> Forncedores</h2>

    <Supplier :list="form.suppliers" v-if="form.suppliers.length >= 1"/>

    <div class="buttons">
      <button type="button" @click="onSubmit"> Editar Empresa</button>
    </div>

    
  </div>
</template>

<style lang="scss">
  .card {
    color: #888;

    margin-top: 5rem;
    display: flex;
    align-items: center;
    flex-direction: column;

    .register_form {
      width: 80vw;

      .row {
        display: flex;
        flex-direction: row;
        justify-content: space-between;

        input {
          width: 100%;
          padding: 1rem;
          border: transparent;
          border-radius: .5rem;
          font-size: 1rem;
          margin: .5rem;
        }
      }
      
    }

    .buttons {
      display: flex;
      padding: 1rem;

      button {
        margin: 1rem;
      }
    }
  }
</style>
