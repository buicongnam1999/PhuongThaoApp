<template>
    <div class="product">
        <header-basic @openForm="openForm">Danh sách sản phẩm</header-basic>
        <div class="product-header-function">
            <input-search />
            <button-refresh />
        </div>
        <div class="product-table">
            <product-table />
        </div>
        <dialog-product :isHide="isHide" @closeForm="closeForm"/>
    </div>
</template>

<script>
import HeaderBasic from '../../components/basic/HeaderBasic.vue'
import ButtonRefresh from '../../components/basic/ButtonRefresh.vue'
import InputSearch from '../../components/basic/InputSearch.vue'
import ProductTable from '../../components/product/ProductTable.vue'
import DialogProduct from '../../components/product/DialogProduct.vue'
export default {
  components: { 
      HeaderBasic,
      InputSearch,
      ButtonRefresh,
      ProductTable,
      DialogProduct
    },
    data() {
        return {
            isHide: true
        }
    },
    methods: {
        openForm: function() {
            this.isHide =!this.isHide
        },
        closeForm: function() {
            this.isHide =!this.isHide
        },
    },
}
</script>

<style scoped>
.product-header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>