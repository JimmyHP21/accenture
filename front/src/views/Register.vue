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
        },
        list: {
          nameSupplier: '',
			    cnpjSupplier: '',
			    stateRegistration: '',
			    business: ''
        }
      }
    },

    methods: {
      onSubmit() {
        axios
          .post("https://localhost:5001/api/Company/new", this.form)
          .then(() => {
            router.replace({ path: '/' })
          })
          .catch((error) => {
            console.log(error)
          })
      },
      addSupplier() {
        this.form.suppliers.push({
          nameSupplier: this.list.nameSupplier,
			    cnpjSupplier: this.list.cnpjSupplier,
			    stateRegistration: this.list.stateRegistration,
			    business: this.list.business
        })

        this.clean()
      },
      clean() {
        this.list = {
          nameSupplier: '',
			    cnpjSupplier: '',
			    stateRegistration: '',
			    business: ''
        }
      }
    },
  }
</script>


<template>
  <div class="card">

    <h2> Empresa</h2>

    <form class="register_form">
      <div class="row">
        <input v-model="form.NameCompany" placeholder="Nome da Companhia"  />
        <input v-model="form.CnpjCompany" placeholder="CNPJ da Companhia"  />
      </div>
      <div class="row">
        <input v-model="form.StateRegistration" placeholder="Registro de Estado"  />
      </div>
      <div class="row">
        <input v-model="form.Address" placeholder="Endereço"  />
        <input type="number" v-model="form.Number" placeholder="Numero"  />
      </div>
      <div class="row">
        <input v-model="form.City" placeholder="Cidade"  />
        <input v-model="form.Cep" placeholder="00000-000" />
        <input v-model="form.State" placeholder="Estado"  />
      </div>
      <div class="row">
        <input v-model="form.PhoneCompany" placeholder="Telefone"  />
      </div>
      
      
      
    </form>

    <h2> Forncedor</h2>

    <form class="register_form">
      <div class="row">
        <input v-model="list.nameSupplier" placeholder="Nome do Fornecedor"  />
        <input v-model="list.cnpjSupplier" placeholder="CNPJ do Fornecedor"  />
      </div>
      <div class="row">
        <input v-model="list.stateRegistration" placeholder="Registro de Estado"  />
        <input v-model="list.business" placeholder="Ramo"  />
      </div>
    </form>

    <Supplier :list="form.suppliers" v-if="form.suppliers.length >= 1"/>

    <div class="buttons">
      <button type="button" @click="onSubmit"> Salvar Empresa</button>
      <button type="button" @click="addSupplier">Adicionar Fornecedor</button>
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
