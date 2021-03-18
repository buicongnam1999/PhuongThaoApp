<template>
    <div :class="{isHidePop: isHide}">
         <div class="popup">

         </div>
    </div>
</template>

<script>
export default {
    data() {
        return {
            
        }
    },
    props:{
        isHidePop: Boolean
    }
}
</script>

<style scoped>
.isHide{

}
</style>