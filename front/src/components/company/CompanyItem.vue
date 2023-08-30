<template>
  <div class="item-company">
    <div class="objects">
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
    

    <div class="buttons">
      <slot></slot>
    </div>
  </div>
</template>

<style lang="scss">
  .item-company {
    width: 60%;
    margin-top: 2rem;
    display: flex;
    align-items: center;
    justify-content: space-around;
    background-color: #fff;
    color: #000;
    border: 1px solid;
    border-radius: 0.5rem;
    padding: 1rem;

    .objects {
      display: flex;
      flex-direction: column;
      align-items: baseline;

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

    .buttons {
      button {
        width: 1rem;
        border-radius: 10rem;
        background-color: #888;

        display: flex;
        align-items: center;
        justify-content: center;
        margin: .5rem 0;
      }
    }
  }
</style>
