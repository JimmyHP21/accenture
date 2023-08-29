<template>
  <div class="item-company">
    <div class="company-numbers">
      <div>
        <span>CNPJ: </span><slot name="cnpj"></slot>
      </div>
      <div>
        <span>Registro: </span><slot name="stateRegi"></slot>
      </div>
    </div>
      
    <div class="details">
      <span>Endereço: </span> <slot name="address"></slot>, <slot name="number"></slot>,
                <slot name="city"></slot> - <slot name="state"></slot>
    </div>

    <div class="supplier-list">
      <span>Quantidade de Fornecedores: </span> <slot name="forn"></slot>
    </div>
  </div>
</template>

<style lang="scss">
  .item-company {
    width: 60%;
    margin-top: 2rem;
    display: flex;
    align-items: baseline;
    position: relative;
    flex-direction: column;
    background-color: #fff;
    color: #000;
    border: 1px solid;
    border-radius: 0.5rem;
    padding: 1rem;

    .company-numbers {
      display: flex;

      div {
        margin-right: 1rem;
        span {
          font-weight: 600;
        }
      }
    }

    .details {
      flex: 1;
      margin-left: 1rem;

      span {
          font-weight: 600;
      }
    }

    .supplier-list {
      flex: 1;
      margin-left: 1rem;

      span {
          font-weight: 600;
      }
    }
  }
</style>
